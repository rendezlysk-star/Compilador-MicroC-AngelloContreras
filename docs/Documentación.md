#  Documentación Técnica - Compilador MicroC (Fase 1)

## 1. Visión General y Arquitectura del Proyecto
El presente proyecto abarca la **Fase 1 (Frontend y Entorno de Trabajo)** del compilador MicroC. Está desarrollado utilizando el lenguaje C# y el framework **.NET 10.0** bajo la tecnología Windows Forms.

## 2. Dependencias y Capa de Presentación (UI)
Para romper con las limitaciones visuales de la API nativa de Win32, la interfaz gráfica implementa la librería externa **ReaLTaiizor** (específicamente la suite de controles `Crown`). 
* **Renderizado Customizado:** Se reemplazaron los `MessageBox` nativos por `CrownMessageBox` para mantener la consistencia del tema oscuro (Dark Mode).
* **Manejo de Diálogos:** Se emplean las clases `ReaLTaiizor.Enum.Crown.DialogButton` para interceptar las respuestas del usuario (`DialogResult.Yes / No`) de forma segura antes de la manipulación de archivos.

## 3. Gestión de Estado y Memoria Local
1. `string rutaArchivoActual`: 
   * **Propósito:** Almacena la ruta absoluta del archivo `.c` cargado en el buffer.
   * **Comportamiento:** Se inicializa como un string vacío (`""`). El sistema evalúa esta variable durante la rutina de guardado para bifurcar el flujo: si está vacía, invoca un `SaveFileDialog` (creación); si contiene una ruta, ejecuta un sobreescrito silencioso (actualización).

2. `bool archivoModificado`: 
   * **Propósito:** Bandera de control de cambios (Dirty Flag).
   * **Comportamiento:** Pasa a estado `true` mediante el disparador del evento `TextChanged` del editor principal. Previene la fuga de memoria o pérdida de datos (Data Loss) interceptando el evento de cierre de la aplicación para forzar una rutina de guardado si el estado es verdadero. Retorna a `false` tras cualquier operación exitosa de I/O.

## 4. Operaciones de Entrada y Salida (File I/O)
El sistema interactúa con el disco duro a través del espacio de nombres `System.IO`:
* **Lectura (`File.ReadAllText`):** Carga el contenido completo del archivo seleccionado mediante un `OpenFileDialog` pre-filtrado para extensiones `(*.c)`. El texto se transfiere directamente a la propiedad `Text` del control de edición, el cual se bloquea (`ReadOnly = true`) temporalmente como medida de seguridad.
* **Escritura (`File.WriteAllText`):** Vuelca el buffer de texto actual hacia la ruta física en el disco duro, garantizando que el archivo fuente esté sincronizado con el entorno visual.

La arquitectura actual prepara el terreno para las futuras actualizaciones. 