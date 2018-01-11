Ejercicio examen para un nuevo candidato
 
Descripción del problema y solución:
El siguiente programa obtiene la cantidad de facturas de un cliente en un rango de fechas
Se cuentan con 3 opciones de búsqueda
-La primera realiza una búsqueda por cada día del rango de fechas especificado
-La segunda realiza una búsqueda dividiendo de forma recursiva a la mitad cada rango de fechas si este contiene más de 100 facturas
-La segunda realiza una búsqueda dividiendo de forma recursiva en intervalos de tamaño aleatorio cada rango de fechas si este contiene más de 100 facturas

Forma de ejecución:
1.- Entrar a la siguiente ruta http://resuelveexamen.azurewebsites.net/
2.- Ingresar el número del cliente de prueba 8672e846-9c89-4dbf-a1cc-b85a2da5abe1
3.- Especificar el rango de fechas que se necesite
4.- Elegir el tipo de búsqueda

Descripción del código:
El proyecto se encuentra programado en .Net
Se utiliza el framework MVC para mostrar los resultados
El proyecto se encuentra dividido en diferentes soluciones las cuales son las capas de la aplicación, las capas son:
-Utils: Que contienen utilidades generales que se pueden utilizar en cualquier otro proyecto
-Models: Contiene la información de los modelos de la solución
-Data: Es la capa de acceso a datos, en este caso es la capa encargada de generar las peticiones al endpoint proporcionado
-Logic: Es la capa de negocio, aquí se encuentran programados los algoritmos
-Web: Es la capa visual, aquí está el proyecto MVC con el cual el usuario final interactua con el sistema

Desarrollado por:
José Jair Guillén García Ing. en sistemas computacionales
