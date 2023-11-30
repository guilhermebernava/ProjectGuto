## Comando para criar o banco de dados
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Teste21@%sd' -p 1433:1433 --name sql-server-movies -d mcr.microsoft.com/mssql/server:2019-latest
 *** precisa criar o banco ainda, o comando so cria uma instancia do SQL SERVER com usuario e senha para conectar nele.