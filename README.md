## JuegoVR-II <!-- omit in toc -->

- Universidad de La Laguna
- **Asignatura:** Interfaces Inteligentes
- **Trabajo Final de Asignatura:** juego en realidad virtual con *Unity 3D*

<br>



## Índice <!-- omit in toc -->

- [Autores](#autores)
- [Introducción](#introducción)
  - [Descripción del juego](#descripción-del-juego)
- [Estructura de los scripts](#estructura-de-los-scripts)
- [Elementos externos usados](#elementos-externos-usados)
- [Cuestiones importantes para el uso](#cuestiones-importantes-para-el-uso)
- [Hitos de programación logrados](#hitos-de-programación-logrados)
- [Aspectos destacables del juego](#aspectos-destacables-del-juego)
- [Metodología de trabajo](#metodología-de-trabajo)
- [Reparto de tareas](#reparto-de-tareas)
- [Gifs de demostración del juego](#gifs-de-demostración-del-juego)
- [Enlaces de interés](#enlaces-de-interés)
  - [Gameplay del juego](#gameplay-del-juego)
  - [APK](#apk)
  - [Github Proyecto completo](#github-proyecto-completo)
- [Posibles mejoras a futuro](#posibles-mejoras-a-futuro)

<br>

## Autores 

- Óscar Moreira Estévez
- Miguel Ángel Ordoñez 
- Christian Torres González

<br>

## Introducción

Este juego llamado **Hunter Jaeger**, es un juego en **realidad virtual (VR)** creado para dispositivos Android creado con *Unity 3D*.

<br>

### Descripción del juego

Cuando entres a jugar a **Hunter Jaeger** te encontrarás en una isla perdida donde tendrás como objetivo matar al gran dragón protector de la cueva. Si quieres aumentar tu poder o tu vida inicial para combatir contra este dragon deberás ir por el mapa buscando elementos que te proporcionen estas mejoras, pero no sin antes haber matado a los dragones protectores de estos elementos que son súbditos del protector de la cueva.

Si quieres llegar a entrar a la cueva tendrás que encontrar también por el mapa alguna granada para derribar la entrada.

> NOTA: sólo contarás con una pistola y tu inteligencia para poder conseguir el objetivo

<br>

## Estructura de los scripts

- Canvas
  - CompassFollowCharacter.cs
  - ShowPlayerHealth.cs
- Enemy
  - FollowPlayer.cs
- LifeSystem
  - Controller
    - controladorDelegados.cs
  - Enemy
    - damageTroll.cs
    - vidaTroll.cs
  - Player
    - damagePlayer.cs
    - vidaJugador.cs
- Menu
  - PlayButton.cs
  - QuitButton.cs
  - StartButton.cs
- Movement
  - RigidbodyCharacter.cs
- Recollect
  - RecollectKeys
    - RecollectKeys.cs
    - RecollectedKeys.cs
  - coleccionableVida.cs
- Weapon
  - Shot.cs
  - eliminarBala.cs

<br>

## Elementos externos usados

Para el juego se han usado elementos externos conseguidos en la **Asset Store** aunque posteriormente se han modificado a nuestro gusto como pueden ser los siguientes:

  - Modelo de la pistola
  - Modelo de la cueva (Posteriormente modificado por completo a nuestro gusto)
  - Figuras que servirán como elementos para obtener vida o poder
  - Modelo de una granada
  - Dragones

<br>

## Cuestiones importantes para el uso


<br>

## Hitos de programación logrados

<br>

## Aspectos destacables del juego

<br>

## Metodología de trabajo

Para este proyecto se ha usado una metodología **Scrum**, de tal manera que hemos ido poniendo objetivos para una fecha en concreta, repartiendonos las tareas y haciendo reuniones en estas fechas de entregas para ver si hemos conseguido los objetivos propuestos, que poder mejorar y pensar en nuevos objetivos para la siguiente fecha.

Para llevar un control de todo el trabajo hemos usado **git** para el control de versiones del proyecto y **github** como plataforma para alojarlo en la nube y así de esta manera poder tener un control mayor del proyecto, trabajar en equipo sin problemas y tener la seguridad de que no perdemos nuestros avances.

<br>

## Reparto de tareas

- **Óscar Moreira Estévez**
  - Recolectar objetos
  - Creación de pistola y disparo de la misma
  - Iluminación de la cueva
  - Enemigos
  - Persecución del enemigo al jugador
  - Funcionamiento de la Brújula
  - Canvas con Brújula en el juego
  - Documentación del proyecto
  
- **Miguel Ángel Ordoñez**
  - Mapa del juego
  - Canvas de la vida y daño del juego
  - Pistola en primera persona en VR
  - Menú del juego cuando empieza el juego y cuando acaba

- **Christian**
  - Sitema de vida y daño del jugador y enemigos
  - Elementos de vida y poder en el mapa
  - Efectos de sonido del juego

- **Tareas en común**

## Gifs de demostración del juego

<br>

## Enlaces de interés

### Gameplay del juego
En el siguiente enlace pueden encontrar un video de demostración del juego donde se demuestran todo lo creado en este proyecto:

- [Enlace al gameplay](https://drive.google.com/drive/folders/1-cQTrgxszc4wIrp4r8fXu5XaZrM-wVMj?usp=sharing)

### APK

En este enlace encontrarán la apk del juego para Android para poder descargarla y probarlo:

- [Enlace a la APK](https://drive.google.com/drive/folders/1YtmsQQzDkYqvRnYO_EpQO6FjYOqmcLBc?usp=sharing)

### Github Proyecto completo

En el siguiente enlace encontrarán un repositorio de Github donde se encuentra todo el proyecto completo para poder descargarlo y ejecutarlo en Unity:

- [Enlace a repositorio del proyecto en Unity](https://github.com/omorest/Proyecto_Final_II)
  
<br>

## Posibles mejoras a futuro