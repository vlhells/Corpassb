Для успешного запуска приложения необходимо задать строку подключения к базе данных.
Это можно сделать так:
1) В папке Corpassb\Corpassb, где находится файл "Corpassb.csproj" необходимо запустить терминал
и прописать в нём следующую команду:
dotnet user-secrets init
2) В том же окне терминала прописать команду:
dotnet user-secrets set ConnectionStrings:EfCoreBasicDatabase "строка_подключения_к_базе_данных"
3) Проект можно запускать.