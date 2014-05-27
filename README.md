INE-Bancos!	{#welcome}
=====================

INE-Bancos es un software orientado a medianas empresas para que puedan llevar un control diario de sus movimientos bancarios, generar reportes mensuales, consultar saldos y realizar conciliaciones a las diferentes cuentas bancarias que tenga la empresa. Este software utiliza una interfaz amigable para el usuario y pueda realizar cualquier operación fácilmente.

----------

Requisitos del software
---------

> **NOTA:** Este software solo trabaja sobre el sistema operativo Windows:
>
> - Windows FrameWork 4.5, lo encontramos en [http://www.microsoft.com/es-es/download/details.aspx?id=30653][1],
> - MySql, descargandolo desde su página oficial [http://dev.mysql.com/downloads/installer/][1],
> - Connector Odbc MySql, se puede descargar en el siguiente link [http://dev.mysql.com/downloads/connector/odbc/][1]

------------

Configuración
------------


#### <i class="icon-pencil"></i> Instalación base de datos

- Debemos de instalar MySql y seguidamente el Connector ODBC que habamos descargado

#### <i class="icon-hdd"></i> Configuración ODBC

- Buscamos la configuración ODBC en nuestro sistema [![Build Status](https://googledrive.com/host/0B-bV7FaOGzAYQkNfZ2RxZHV6VWc/f1.jpg)](https://github.com/guicho0601)

- Agregamos una nueva conexión a nuestras ODBC  [![Build Status](https://googledrive.com/host/0B-bV7FaOGzAYQkNfZ2RxZHV6VWc/f2.jpg)](https://github.com/guicho0601)

- Seleccionamos el Driver de MySQL [![Build Status](https://googledrive.com/host/0B-bV7FaOGzAYQkNfZ2RxZHV6VWc/f3.jpg)](https://github.com/guicho0601)

- Ingresamos los datos de nuestro servidor, usuario y contraseña utilizando **ine_bancos** como nombre de la odbc y nombre de la database que vamos a utilizar [![Build Status](https://googledrive.com/host/0B-bV7FaOGzAYQkNfZ2RxZHV6VWc/f4.jpg)](https://github.com/guicho0601)

#### <i class="icon-pencil"></i> Ejecución del script de la base de datos

Ejecutamos el script que se encuentra en el repositorio **Script-DataBase.sql** en la consola de MySql, esto creará las tablas y relaciones necesarias en la base de datos e ingresará algunos datos para poder empezar a trabajar.

#### <i class="icon-hdd"></i> Y ahora ya se puede ejecutar exitosamente el software INE-Bancos

-----------------

Usuario y contraseña del software
----------------

>**El software no necesita ningún usuario ni contraseña, por razones que no ha sido implementado los WebServices necesarios para poder comprobar el login.**

-----------------

Equipo de desarrollo
-----------------

>- Edwin Ottoniel Rodriguez Taylor 
>- Mario Alexander Godoy Tobar
>- Guillermo Canel
>- Rony Alejandro Caracún Cruz
>- Luis Angel Ramos Gómez