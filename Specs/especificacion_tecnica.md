# Actividad 17 — Entity Framework Core con Blazor

## Objetivo
Configurar e implementar **Entity Framework Core (EF Core)** sobre el proyecto Blazor de la Actividad 15, estableciendo persistencia de datos en **SQL Server LocalDB** con operaciones CRUD completas.

## Tecnologías
| Tecnología | Versión |
|---|---|
| .NET / ASP.NET Core | 10 |
| Blazor Server | 10 |
| Entity Framework Core | 10.0.14 |
| SQL Server (LocalDB) | — |

## Paquetes NuGet instalados
```
Microsoft.EntityFrameworkCore.SqlServer  10.0.14
Microsoft.EntityFrameworkCore.Tools      10.0.14
Microsoft.EntityFrameworkCore.Design     10.0.14
```

## Estructura del proyecto
```
Act15/
├── Components/
│   └── Pages/
│       └── Estudiantes.razor     ← Componente CRUD principal
├── Data/
│   └── ApplicationDbContext.cs   ← DbContext de EF Core
├── Migrations/                   ← Migraciones generadas
├── Models/
│   └── Estudiante.cs             ← Entidad con Data Annotations
├── Specs/
│   └── especificacion_tecnica.md ← Este documento
├── appsettings.json              ← Cadena de conexión
└── Program.cs                    ← Registro del DbContext
```

## Cadena de conexión
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EstudiantesDB;Trusted_Connection=True;"
}
```

## Migraciones
La migración `InitialCreate` genera la tabla `Estudiantes` con las columnas:

| Columna | Tipo | Restricciones |
|---|---|---|
| Id | int | PK, Identity |
| Nombre | nvarchar(100) | NOT NULL |
| Correo | nvarchar(150) | NOT NULL |
| Calificacion | float | NOT NULL |

Comando usado:
```bash
dotnet-ef migrations add InitialCreate
```

## Operaciones CRUD implementadas
| Operación | Método | Descripción |
|---|---|---|
| **Create** | `GuardarEstudiante()` | Agrega un estudiante nuevo |
| **Read**   | `CargarEstudiantes()` | Carga todos con `ToListAsync()` |
| **Update** | `IniciarEdicion()` + `GuardarEstudiante()` | Edita in-place |
| **Delete** | `EliminarEstudiante(id)` | Elimina por ID |

## Validaciones
- Nombre: requerido, máx. 100 caracteres.
- Correo: requerido, formato email válido, máx. 150 caracteres.
- Calificación: requerida, rango 0 – 10.

## Ejecución
```bash
dotnet run
# Navegar a: http://localhost:5239/estudiantes
```
La aplicación aplica las migraciones automáticamente al arrancar (`db.Database.Migrate()`).
