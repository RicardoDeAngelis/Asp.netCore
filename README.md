# Asp.netCore
Creacion de un  ABM de clientes 

Se utilizo Visual Studio Code

En consola o powerShell (ir a la ubicacion del proyecto)
instalar certificados https con:dotnet dev-certs https--trust
Crear appWeb mvc: dotnet new mvc -NombreProyecto

Paquetes:
libreria de gestion de datos
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet restore
    
    Scallfolding(Reconstruir vistas y controlador)
    dotnet aspnet-codegenerator controller -name ClienteController
    -m ClienteModel -dc ClienteContext
    –relativeFolderPath Controllers --useDefaultLayout
    –referenceScriptLibraries -f 

En la rama master y creandoDBenAzure tenemos una version sencilla del ABM sin usar Scafollding ,con base de datos en Azure y
configurada para usar sql-server

En la rama DbInMemory tenemos una version sencilla del ABM sin usar Scafollding ,con base de datos InMemory,no necesitamos configurar una DB.

En la rama dbInMemoryScaffolding  tenemos una version sencilla del ABM usando Scafollding ,
con base de datos InMemory,no necesitamos configurar una DB.


En la rama usandoScaffolginf tenemos una version sencilla del ABM  usando Scafollding ,con base de datos en Azure y
configurada para usar sql-server.


