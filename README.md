# Proyecto de Consola en .NET Framework 4.8

Este proyecto es una aplicación de consola desarrollada en .NET Framework 4.8. A continuación, se detallan los pasos para compilar y ejecutar el proyecto correctamente.

## Requisitos Previos

1. **.NET Framework 4.8**: Asegúrate de tener instalado .NET Framework 4.8 en tu máquina. Puedes descargarlo desde [aquí](https://dotnet.microsoft.com/download/dotnet-framework/net48).

2. **Visual Studio**: Recomendamos usar Visual Studio 2019 o posterior. Puedes descargarlo desde [aquí](https://visualstudio.microsoft.com/).

## Clonar el Repositorio

Primero, clona el repositorio a tu máquina local utilizando Git:

```bash
git clone https://github.com/YisethVelez000/ToDoList-Prueba
```

También puedes descargar el repositorio como un archivo ZIP y extraerlo en tu máquina local.

Abrir el proyecto en Visual Studio 2019 o posterior.
```bash 
cd ToDoList-Prueba
```


## Compilar el Proyecto
Para compilar el proyecto, abre el archivo de solución (.sln) en Visual Studio y sigue estos pasos:

Abre Visual Studio.
Selecciona Archivo > Abrir > Proyecto/Solución y elige el archivo .sln.
En el menú superior, selecciona Compilar > Compilar Solución o presiona Ctrl+Shift+B.
Visual Studio compilará el proyecto y generará el archivo ejecutable en la carpeta bin\Debug o bin\Release, dependiendo de la configuración de compilación.

## Ejecutar el Proyecto
Para ejecutar el proyecto desde Visual Studio:

Asegúrate de que la solución esté compilada correctamente.
Presiona F5 para ejecutar el proyecto en modo depuración o Ctrl+F5 para ejecutarlo sin depuración.

## Funcionalidades
**Agregar Tareas:** Añade nuevas tareas con nombre, descripción y fecha límite (opcional).
**Listar Tareas:** Muestra todas las tareas registradas en la lista.
**Marcar Tarea como Completada:** Marca una tarea como completada.
**Eliminar Tarea:** Elimina una tarea de la lista.

## Manejo De Errores
El proyecto maneja errores en la entrada de datos del usuario, como fechas inválidas o índices incorrectos. Además, se incluyen mensajes de error descriptivos para guiar al usuario en caso de que ocurra un error.