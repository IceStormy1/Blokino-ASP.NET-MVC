using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        
        public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
        {
            _userManager = userMgr;
            _signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        if (user.NormalizedUserName == "ADMIN")
                        {
                            return Redirect("/admin");
                        }
                        else
                        {
                            return Redirect(returnUrl ?? "/");
                        }
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
            }
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new RegistrationViewModel());
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegistrationViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.LoginReg, 
                    Email = model.EmailReg,
                    EmailConfirmed = true,
                    NormalizedUserName = model.LoginReg.ToUpper(), 
                    NormalizedEmail = model.EmailReg.ToUpper(), 
                    SecurityStamp = string.Empty, PhoneNumber = model.PhoneReg, 
                    TwoFactorEnabled = false, 
                    LockoutEnd = null, 
                    LockoutEnabled = false,
                };

                var createResult = await _userManager.CreateAsync(user, model.PasswordReg);

                if (createResult.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "HomeControllerDef");
                }

                foreach (var identityError in createResult.Errors)
                {
                    ModelState.AddModelError("", identityError.Description);
                }
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "HomeControllerDef");
        }
    }
}
