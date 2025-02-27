# Gestor de Alumnos

Una aplicación de escritorio en C# que permite gestionar un grupo de alumnos, calcular sus calificaciones, agregar nuevos alumnos, modificar notas, y consultar detalles sobre ellos. Utiliza Windows Forms para la interfaz gráfica de usuario.

## Funcionalidades

La aplicación incluye las siguientes funcionalidades:

1. **Agregar Alumno**: Permite agregar un nuevo alumno al sistema introduciendo su DNI, nombre, apellidos y nota. La calificación se calcula automáticamente según la nota.
2. **Eliminar Alumno**: Permite eliminar un alumno del sistema a partir de su DNI.
3. **Consultar Alumno**: Permite consultar la nota y la calificación de un alumno a partir de su DNI.
4. **Modificar Nota**: Permite modificar la nota de un alumno y recalcular su calificación automáticamente.
5. **Mostrar Suspensos**: Muestra a todos los alumnos con calificación suspendida (nota menor a 5).
6. **Mostrar Aprobados**: Muestra a todos los alumnos con calificación aprobada (nota mayor o igual a 5).
7. **Mostrar Candidatos a Matrícula de Honor**: Muestra a los alumnos que tienen una nota de 10, candidatos a Matrícula de Honor.
8. **Modificar Calificación**: Permite modificar manualmente la calificación de un alumno (aunque la calificación se calcula automáticamente, el sistema permite modificarla manualmente).

## Requisitos

- Visual Studio 2019 o superior.
- .NET Framework 4.7.2 o superior.
- Sistema operativo Windows para la ejecución de la interfaz gráfica.

# Gestor de Alumnos

## Instalación

1. **Clonar el repositorio**

    ```bash
    git clone https://github.com/tu-usuario/gestor-alumnos.git
    ```

2. **Abrir el proyecto**

    - Abre Visual Studio.
    - Selecciona **Abrir proyecto** y navega a la carpeta donde descargaste el repositorio.
    - Abre el archivo `GestorAlumnosApp.sln`.

3. **Compilar y ejecutar**

    - Haz clic en **Build > Build Solution** para compilar el proyecto.
    - Después de compilar, haz clic en **Start** o presiona **F5** para ejecutar la aplicación.

## Uso

### Interfaz Principal

- **Agregar Alumno**: Introduce el DNI, apellidos, nombre y la nota. Haz clic en el botón **Agregar Alumno** para guardar el alumno en el sistema.
- **Eliminar Alumno**: Introduce el DNI del alumno que deseas eliminar y haz clic en **Eliminar Alumno**.
- **Consultar Alumno**: Introduce el DNI del alumno y haz clic en **Consultar Alumno** para ver su nota y calificación.
- **Modificar Nota**: Introduce el DNI del alumno y la nueva nota. Haz clic en **Modificar Nota** para cambiar la nota y recalcular la calificación.
- **Mostrar Suspensos**: Haz clic en **Mostrar Suspensos** para ver a los alumnos con calificación "SS".
- **Mostrar Aprobados**: Haz clic en **Mostrar Aprobados** para ver a los alumnos con calificación "AP" o superior.
- **Mostrar Candidatos a Matrícula de Honor**: Haz clic en **Mostrar Candidatos a MH** para ver a los alumnos con calificación de 10.
- **Modificar Calificación**: Introduce el DNI del alumno y la nueva calificación. Haz clic en **Modificar Calificación** para cambiar la calificación manualmente.

## Estructura del Proyecto

El proyecto se compone de las siguientes clases principales:

- **Alumno**: Contiene las propiedades del alumno (DNI, nombre, apellidos, nota y calificación). La calificación se calcula automáticamente en función de la nota.
- **GestorAlumnos**: Gestiona la lista de alumnos y proporciona métodos para agregar, eliminar, consultar, modificar notas y calificaciones.
- **Form1**: La interfaz gráfica donde el usuario interactúa con el sistema, utilizando los controles de Windows Forms.

## Capturas de pantalla
![Pantalla de inicio](/imagenes/Image.png)
![Pantalla de añadir estudiante](/imagenes/Imagen1.png)
![Pantalla añadir estudiante exitoso](/imagenes/Imagen2.png)
![Pantalla estudiante añadido](/imagenes/Imagen3.png)
![Pantalla de añadir estudiante2](/imagenes/Imagen4.png)
![Pantalla estudiante2 añadido](/imagenes/Image5.png)
![Pantalla añadido estudiante 2 exitoso](/imagenes/Imagen6.png)
![Pantalla consulta](/imagenes/Imagen7.png)
![Pantalla modificacion de nota](/imagenes/Imagen8.png)
![Pantalla modificacion existosa ](/imagenes/Imagen9png)
![Pantalla final ](/imagenes/Imagen9png)

## Contribuciones

¡Las contribuciones son bienvenidas! Si encuentras algún error o deseas agregar nuevas funcionalidades, siéntete libre de hacer un fork del proyecto y enviar un pull request.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.

