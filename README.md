# Blokino 

## Описание

Данный проект был создан в качестве тестового задания. 

Сайт построен на ASP.NET MVC, в качестве СУБД используется MSSQL. 

## Установка проекта

1. Для начала необходимо скачать и установить [Microsoft SQL Server](https://www.microsoft.com/ru-ru/sql-server/sql-server-downloads). 

2. Далее необходимо скачать проект. Сделать это можно либо кликнув на [Download ZIP](https://github.com/IceStormy1/Site/archive/refs/heads/master.zip) и разархивировать его в любом удобном месте, либо же в Git Bash прописать команду `git clone git@github.com:IceStormy1/Site.git`

3. Открываем файл `appsettings.json` и в строке `ConnectionString` меняем `Data Source` на имя сервера, `User ID` и `Password` на логин и пароль от  пользователя в MSSQL соответственно.

4. Далее необходимо выполнить миграцию. Открываем командную строку `cmd` и прописываем три команды
> dotnet tool update --global dotnet-ef <br>
 cd (Путь до проекта) <br>
 dotnet ef database update

Установка завершена :)
