# Proyecto de Consola en .NET Framework 4.8

Este proyecto es una aplicaci�n de consola desarrollada en .NET Framework 4.8. A continuaci�n, se detallan los pasos para compilar y ejecutar el proyecto correctamente.

## Requisitos Previos

1. **.NET Framework 4.8**: Aseg�rate de tener instalado .NET Framework 4.8 en tu m�quina. Puedes descargarlo desde [aqu�](https://dotnet.microsoft.com/download/dotnet-framework/net48).

2. **Visual Studio**: Recomendamos usar Visual Studio 2019 o posterior. Puedes descargarlo desde [aqu�](https://visualstudio.microsoft.com/).

## Clonar el Repositorio

Primero, clona el repositorio a tu m�quina local utilizando Git:

```bash
git clone https://github.com/YisethVelez000/ToDoList-Prueba
```

Tambi�n puedes descargar el repositorio como un archivo ZIP y extraerlo en tu m�quina local.

Abrir el proyecto en Visual Studio 2019 o posterior.
```bash 
cd ToDoList-Prueba
```


## Compilar el Proyecto
Para compilar el proyecto, abre el archivo de soluci�n (.sln) en Visual Studio y sigue estos pasos:

Abre Visual Studio.
Selecciona Archivo > Abrir > Proyecto/Soluci�n y elige el archivo .sln.
En el men� superior, selecciona Compilar > Compilar Soluci�n o presiona Ctrl+Shift+B.
Visual Studio compilar� el proyecto y generar� el archivo ejecutable en la carpeta bin\Debug o bin\Release, dependiendo de la configuraci�n de compilaci�n.

## Ejecutar el Proyecto
Para ejecutar el proyecto desde Visual Studio:

Aseg�rate de que la soluci�n est� compilada correctamente.
Presiona F5 para ejecutar el proyecto en modo depuraci�n o Ctrl+F5 para ejecutarlo sin depuraci�n.

## Funcionalidades
**Agregar Tareas:** A�ade nuevas tareas con nombre, descripci�n y fecha l�mite (opcional).
**Listar Tareas:** Muestra todas las tareas registradas en la lista.
**Marcar Tarea como Completada:** Marca una tarea como completada.
**Eliminar Tarea:** Elimina una tarea de la lista.

## Manejo De Errores
El proyecto maneja errores en la entrada de datos del usuario, como fechas inv�lidas o �ndices incorrectos. Adem�s, se incluyen mensajes de error descriptivos para guiar al usuario en caso de que ocurra un error.