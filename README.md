# AAD2_IeltxuAlbinHaya

Repositorio para el examen de acceso a datos del 4 de febrero de 2026.

## Requisitos Previos

Antes de comenzar, asegúrate de tener instalados los siguientes programas en tu máquina:

- [Visual Studio](https://visualstudio.microsoft.com/) (versión 2022 o superior)
- [Docker](https://www.docker.com/get-started)

## Configuración del Proyecto

1. **Instalación de la base de datos MySQL:**

Puedes crear un contenedor de MySQL utilizando el siguiente comando:

```bash
docker run --name mysql-server -e MYSQL_ROOT_PASSWORD=root -d -p 3306:3306 mysql:latest
```

Para configurar MySQL, puedes instalar una herramienta como MySQL Workbench y acceder a la base de datos con las credenciales root/root.
Una vez conectado, copia el contenido del archivo `peticionesSQL.txt` en la raíz del proyecto para ejecutarlo como consulta.

```sql
CREATE DATABASE CINE;
USE CINE;
CREATE TABLE PELICULA (
    titulo VARCHAR(255),
    anio_estreno INT,
    duracion INT,
    precio DECIMAL(10, 2),
    sinopsis VARCHAR(400),
    url_imagen VARCHAR(600),
    entradas_disponibles INT
);
INSERT INTO PELICULA (titulo, anio_estreno, duracion, precio, sinopsis, url_imagen, entradas_disponibles) VALUES
('El Bueno, el Feo y el Malo', 1966, 161, 2.5, 'Un cazarrecompensas une fuerzas con un bandido para encontrar un tesoro escondido.', 'https://s1.qwant.com/thumbr/474x632/9/e/001cda5dffabe9a2e407527348e00ea797e9a48318ea128b2c8a8d0171591f/OIP.eTCS-bCWutXe5AuQQ0-GGgHaJ4.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%2Fid%2FOIP.eTCS-bCWutXe5AuQQ0-GGgHaJ4%3Fcb%3Ddefcache2%26pid%3DApi%26defcache%3D1&q=0&b=1&p=0&a=0', 100),
('Los Puentes de Madison', 1995, 135, 3, 'Una mujer casada se enamora de un fotógrafo que llega a su pueblo.', 'https://s2.qwant.com/thumbr/474x628/4/7/558d683356088ad8079a9c9f51b8e874defa47b3cd463a0533f4e34011a866/OIP.l5Z2IaZQznWhBbCqsXVJZQHaJ0.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%2Fid%2FOIP.l5Z2IaZQznWhBbCqsXVJZQHaJ0%3Fcb%3Ddefcachec2%26pid%3DApi&q=0&b=1&p=0&a=0', 50),
('Million Dollar Baby', 2004, 132, 5.2, 'Un entrenador de boxeo forma a una mujer para que se convierta en campeona.', 'https://s2.qwant.com/thumbr/474x711/6/4/e6de6b83fe5efcc658378bc888499bc2b28bb4519b6fdf62b5fc9c8aedf68c/OIP.oUK-bIZg3pE2x8mZU-9d3wHaLH.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%2Fid%2FOIP.oUK-bIZg3pE2x8mZU-9d3wHaLH%3Fcb%3Ddefcachec2%26pid%3DApi&q=0&b=1&p=0&a=0', 75),
('Invictus', 2009, 133, 4.7, 'La historia del mensaje de reconciliación que inspiró a Sudáfrica post-apartheid.', 'https://s1.qwant.com/thumbr/474x711/2/2/30db8a7df97291f5eef508449bcdc6af59c17c33ad87b917a0d9729be4bc83/OIP.9acLVULT6AaU7UGlp-f9vAHaLH.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%2Fid%2FOIP.9acLVULT6AaU7UGlp-f9vAHaLH%3Fpid%3DApi&q=0&b=1&p=0&a=0', 70),
('Gran Torino', 2008, 116, 4.99, 'Un veterano de guerra se convierte en amigo de un joven inmigrante en su vecindario.', 'https://s1.qwant.com/thumbr/474x702/a/e/713848642e783d43ab024f4d2e797f01114d4a84dbb88791e3638af23b2a58/OIP.uYlARjOSczxlAIPwiAxJHwHaK-.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%2Fid%2FOIP.uYlARjOSczxlAIPwiAxJHwHaK-%3Fpid%3DApi&q=0&b=1&p=0&a=0', 60);
```

2. **Clona el repositorio:**

```bash
git clone https://github.com/ieltxuah/AAD2_IeltxuAlbinHaya.git
cd AAD2_IeltxuAlbinHaya/IeltxuAlbinHaya_AADWF
```

3. **Abrir el proyecto:**

Abre el archivo `IeltxuAlbinHaya_AADWF.sln` con Visual Studio y clica a `Iniciar` para ejcutar la aplicación
