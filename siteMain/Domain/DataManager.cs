using siteMain.Domain.Repositories.Abstract;

namespace siteMain.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public  IFilms Films { get; set; }
        public IUserRateFilms UserRateFilms { get; set; }
        public IActors Actors { get; set; }
        public IUserRateActors UserRateActors { get; set; }
        public IFilmsAndActors FilmsAndActors { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IFilms textFilms, IUserRateFilms textUserRateFilms, IActors textActors, IUserRateActors textUserRateActors, IFilmsAndActors textFilmsAndActors)
        {
            TextFields = textFieldsRepository;
            Films = textFilms;
            UserRateFilms = textUserRateFilms;
            Actors = textActors;
            UserRateActors = textUserRateActors;
            FilmsAndActors = textFilmsAndActors;
        }

    }
}
