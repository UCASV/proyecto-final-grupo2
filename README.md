# DOCUMENTACIÓN OFICIAL
## Punto 1

## Aspectos tecnicos

### Version del software utilizado en el desarrollo del programa 
Jet brains Rider  2021.1.1
Jet brains Rider 2021.1.3

### Sistema operativo utilizado
 Windows 10 Pro 20H2(Compilación SO 19042.1052)
 
### Patron de diseño utilizado 
#### MVVM (View model)(Modelo-vista-Modelo de vista).
##### Como?
Se creo una clase por cada entidad/modelo que se quería modificar con la syntaxis de "Nombre de la entidad VM".
Dentro de la clase se crea la información necesaria a extraer de la entidad/modelo.
Se crea una clase mapper/mapped que es una conversión o alteración de un objeto a otro.
se crea un objeto de tipo entidad a entidadVm donde se reciben elementos de tipo entidad y se retornan elementos de tipo entidadVm.
Por ultimo se cargan en un DGV

##### Donde?
El patrón fue implementado en las vistas de:
- Manager
- Formulario Ciudadano
- Citas

##### Por que?
Este patrón de diseño se implemento para cambiar la manera en la que se mostraban los datos de la base y así ocultar información sensible y solo dejar a la vista lo importante para el usuario del programa.

### Paquetes externos 
#### NuGet
Microsoft.EntityFrameworkCore  V.5.0.7
Microsoft.EntityFrameworkCore.Design   V.5.0.7
Microsoft.EntityFrameworkCore.SqlServer   V.5.0.7
iTextSharp V.5.5.13.2   

## Punto 2

### Version del framework

[.Net Core ]
- Framework net 5.0 

### Base de datos
Es necesario tener una base de datos existente y llenar con datos en las siguientes Tablas/Entidades

- "TYPE_EMPLOYEE"
- "MANAGER"
- "INSTITUTION"
- "CABIN"

#### Gestor utilizado

SQL EXPRESS en SQL Server Management Studio

## Punto 3 
### MANUAL DE USUARIO
Mirar PDF adjunto
