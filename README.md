# Prueba250725

Este proyecto es un sistema de gestión de usuarios con roles desarrollado en C# utilizando ASP.NET Core y Entity Framework Core, implementando el enfoque Database-First.

## Tecnologías Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server
- C#

## Requisitos Previos

- Visual Studio 2022
- SQL Server
- .NET 7.0 SDK

## Configuración de la Base de Datos

1. La base de datos ahora está en línea. No es necesario crearla manualmente, solo asegúrate de tener acceso a la conexión remota proporcionada.

Si necesitas los scripts de creación, solicítalos al administrador.

## Configuración del Proyecto

### 1. Paquetes NuGet Requeridos

Instalar los siguientes paquetes NuGet:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

### 2. Generación del Modelo desde la Base de Datos

Ejecutar el siguiente comando en la Consola del Administrador de Paquetes:

```powershell
Scaffold-DbContext "Data Source=.;Initial Catalog=Prueba250725;Integrated Security=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

### 3. Configuración de la Cadena de Conexión

Actualizar el archivo `appsettings.json` con la siguiente configuración:

```json
{
  "ConnectionStrings": {
    "Conn": "Data Source=.;Initial Catalog=Prueba250725;Integrated Security=True;Encrypt=False"
  }
}
```

### 4. Configuración del Program.cs

Agregar la siguiente configuración en `Program.cs`:

```csharp
builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
});
```

## Estructura del Proyecto

- **Controllers/**
  - HomeController.cs
  - RolesController.cs
  - UsersController.cs
- **Models/**
  - ErrorViewModel.cs
  - Prueba250725Context.cs
  - Role.cs
  - User.cs
- **Views/**
  - Roles/ (CRUD views)
  - Users/ (CRUD views + login)

## Funcionalidades

- Gestión completa de usuarios (CRUD)
- Gestión de roles (CRUD)
- Sistema de login
- Validación de datos
- Relaciones entre usuarios y roles

## Seguridad

- Contraseñas encriptadas
- Autenticación de usuarios

# Autor
* Brayan Eduardo Tepas Linares