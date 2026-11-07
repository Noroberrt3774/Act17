# 🎓 Actividad 17 — EF Core + Blazor + SQL Server

Implementación de **Entity Framework Core** sobre la aplicación Blazor de gestión de estudiantes (Actividad 15), con persistencia en **SQL Server LocalDB** y operaciones **CRUD** completas.

---

## 🚀 Características

- ✅ Registrar estudiantes (Nombre, Correo, Calificación)
- ✅ Listar estudiantes desde SQL Server
- ✅ Editar estudiante seleccionado
- ✅ Eliminar estudiante con botón 🗑️
- ✅ Validaciones con Data Annotations
- ✅ Migraciones con EF Core
- ✅ Aplicación automática de migraciones al arrancar

---

## 📦 Paquetes NuGet

```
Microsoft.EntityFrameworkCore.SqlServer  10.0.14
Microsoft.EntityFrameworkCore.Tools      10.0.14
Microsoft.EntityFrameworkCore.Design     10.0.14
```

---

## ⚙️ Configuración

La cadena de conexión en `appsettings.json` apunta a **SQL Server LocalDB**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EstudiantesDB;Trusted_Connection=True;"
}
```

---

## 🗄️ Base de datos

Tabla generada: `Estudiantes`

| Columna | Tipo | Restricción |
|---|---|---|
| Id | int | PK, Identity |
| Nombre | nvarchar(100) | NOT NULL |
| Correo | nvarchar(150) | NOT NULL |
| Calificacion | float | NOT NULL |

---

## ▶️ Ejecutar

```bash
dotnet run
```

Abre en el navegador: `http://localhost:5239/estudiantes`

---

## 📂 Especificación técnica

Ver [`/Specs/especificacion_tecnica.md`](./Specs/especificacion_tecnica.md)
