# InventarioLibros
Taller ejemplo aplicacion de escritorio con .NET - Módulo Acceso a Datos (2 DAM)

Para crear esta aplicación se han seguido los pasos de algunos tutoriales e información oficial de la documentación de Microsoft.

En un primer momento se siguen los pasos de este enlace para tener una base de una aplicación que hace uso de una base de datos existente a la que accede mediante un DataSet tipado:
https://docs.microsoft.com/en-us/visualstudio/data-tools/create-a-windows-form-to-search-data?view=vs-2022

1. Se crea la aplicación de escritorio .NET Framework
2. Se crea el DataSet con origen de datos la base de datos (en el ejemplo de este taller usamos la base de datos Biblioteca ya creada en clases anteriores)
3. Se usan las herramientas de arrastrar y soltar desde el origen de datos para tener una vista tanto de detalle como de tipo DatGridView de la tabla que elijamos. Se prueban 
los botones de navegación y CRUD que se nos crean automáticamente.
4. Se crea un query para seleccionar usando algún campo como filtro, y se incluye ese control de búsqueda en el formulario.

Para más información sobre esa unión entre controles y DataSet, se deja este enlace sobre el "binding" de controles: 
https://docs.microsoft.com/en-us/visualstudio/data-tools/bind-windows-forms-controls-to-data-in-visual-studio?view=vs-2022

En este punto se hacen dos añadidos más extras al tutorial inicial:
- Un botón de eliminar aparte del generado automáticamente. Este botón, cuando se pulsa abre un cuadro de diálogo que pide confirmación para el borrado, y luego, realiza el borrado usando
el método Delete del adaptador de la tabla Libro (que es la que se usa en esta aplicación en cuestión)
- Un Botón de actualizar aparte del generado automáticamente. Este botón actualizará el registro sobre el que esté situado el cursor, y tomando los valores modificados en los controles
de la vista de Detalle, hará una llamada a un procedimiento almacenado de UPDATE, previamente creado en la base de datos, pero  no a través del DataSet sino a través de métodos básicos
de ADO.NET. Aquí enlace con tutorial para conocer la tecnología ADO.NET: https://docs.microsoft.com/es-es/visualstudio/data-tools/create-a-simple-data-application-by-using-adonet?view=vs-2022

Tecnologías de acceso a datos que se ven en el taller: DataSet tipado y ADO.NET


