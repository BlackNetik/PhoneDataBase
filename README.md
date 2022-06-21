# PhoneDataBase
PhoneDataBase — приложение для автоматизации учета кадров на производственном предприятии. Программа предназначена для сотрудников отдела кадров.  
Программа предоставляет возможность хранить, записывать, перезаписывать и удалять данные о сотрудниках в базе данных SQL. Все действия совершаются во вкладке браузера  
## Сборка проекта
Для установки и сборки PhoneDataBase требуется наличие установленной Microsoft Visual Studio 2022 с необходимыми рабочими нагрузками (ASP.NET и разработка веб-приложений; Разработка классических приложений .NET), а также с несколькими отдельными компонентами (.NET Framework 4.8; SQL Server Data Tools; SQL Server Express 2019 LocalDB; SQL Server ODBC Driver). Установка Visual Studio версии 2022 обусловлена тем, что только она поддерживает платформу .NET 6.  
  
Открываем Microsoft Visual Studio. Выбираем “Открыть проект или решение”. В появившемся проводнике выбираем папку PhoneDataBase и жмём кнопку Открыть, или же в этой папке открываем решение PhoneDataBase.sln  
![Открытие](https://github.com/BlackNetik/PhoneDataBase/blob/master/PhoneDataBase/wwwroot/Open.jpg "Открытие")  
Открываем проект. Нажимаем на клавишу F5, или же в разделе Откладка выбираем. Начать откладку. Запускается командная строка, после завершения которой открывается вкладка браузера с нашим проектом.  
Появляется ошибка, в которой сказано, что невозможно получить доступ к базе данных. Жмём на голубую кнопку Apply Migrations, ждём завершения и перезапускаем страницу.  
Это необходимо проделать только при первом запуске. В дальнейшем, можно не запускать Visual Studio, а открывать PhoneDataBase.exe файл, по пути PhoneDataBase\PhoneDataBase\bin\Debug\net6.0. Также, приложение можно опубликовать и собрать в папку для дальнейшего удобства. 
  
## Публикация
Руководство по публикации приложения есть на сайте [Microsoft](https://docs.microsoft.com/ru-ru/visualstudio/deployment/quickstart-deploy-aspnet-web-app?view=vs-2019&tabs=folder). Выставляем настройки публикации. В разделе конфигурация выбираем ***Release***, ***Целевую платформу*** оставляем без изменений, Режим развёртвывания выбираем ***Зависит от платформы*** и в Целевой среде выполнения выбираем пункт ***Переносимая версия***.  
Далее, в подпункте **База данных** ставим галочку на ***использовать эту строку подключения во время выполнения***. В подпункте **Entity Framework Migrations** ставим галочку на ***использовать эту миграции при публикации***. Жмём на кнопку ***Опубликовать*** и дожидаемся окончания публикации. Публикация собрана и готова к запуску.
