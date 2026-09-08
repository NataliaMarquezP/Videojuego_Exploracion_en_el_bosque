# 🌿 Videojuego de Exploración en el Bosque



## 🎮 Descripción

Videojuego de exploración 3D desarrollado en **Unity 6** utilizando **Universal Render Pipeline**, ambientado en un entorno natural de bosque y selva.

El jugador debe recorrer el escenario, superar obstáculos, interactuar con distintos elementos y alcanzar el punto de meta. El mapa incluye un cauce con agua, ruinas, vegetación, trampas y mecanismos que desbloquean nuevas zonas.

## ✨ Características principales

- 🌲 Entorno 3D ambientado en un bosque.
- 🧍 Personaje controlable en tercera persona.
- 🚶 Sistema de caminar y correr.
- 🦘 Sistema de salto y gravedad.
- 📷 Cámara de seguimiento en tercera persona.
- 🧰 Cofre interactivo con monedas.
- 🪨 Roca móvil que desbloquea un pasadizo.
- 🛢️ Trampa de aceite con sistema de reaparición.
- 🌊 Cauce con superficie de agua.
- 🏁 Punto de meta para completar el recorrido.

## ⌨️ Controles

| Acción | Control |
|---|---|
| Mover al personaje | `W`, `A`, `S`, `D` |
| Correr | `Shift izquierdo` |
| Saltar | `Espacio` |
| Abrir el cofre | `E` |
| Mover la roca | `F` |

## 🧩 Interacciones

### 🧰 Cofre

Al acercarse al cofre y pulsar `E`, el cofre cerrado desaparece y es sustituido por un cofre abierto con monedas.

### 🪨 Roca móvil

Al acercarse a la roca y pulsar `F`, la roca se desplaza hacia un punto definido y desbloquea el pasadizo.

### 🛢️ Trampa de aceite

Cuando el personaje toca la trampa, vuelve automáticamente al punto de reaparición ubicado al comienzo del nivel.

### 🏁 Punto de meta

Al llegar al punto final se completa el objetivo principal del recorrido.

## 🛠️ Tecnologías utilizadas

- **Motor:** Unity 6
- **Renderizado:** Universal Render Pipeline
- **Lenguaje:** C#
- **Control del personaje:** Character Controller
- **Control de versiones:** Git y GitHub

  ## 🎥 Vídeo demostrativo

▶️ [Ver demostración del videojuego en YouTube](https://www.youtube.com/shorts/D-gSguYUYbo)

En el vídeo se muestran las principales características del proyecto:

- 🌿 Exploración del escenario.
- 🧍 Movimiento del personaje.
- 🧰 Interacción con el cofre.
- 🪨 Desplazamiento de la roca.
- 🛢️ Funcionamiento de la trampa.
- 🌊 Cauce con agua.
- 🏁 Recorrido hasta el punto de meta.

## 🎨 Recursos de terceros y créditos

Las texturas, imágenes, modelos 3D, materiales y prefabs utilizados en este proyecto fueron obtenidos desde la **Unity Asset Store**.

Estos recursos pertenecen a sus respectivos autores y distribuidores. Su inclusión en el proyecto se realiza únicamente con fines académicos y demostrativos, respetando las licencias correspondientes de cada paquete.

La programación de las mecánicas, la configuración de las interacciones, el diseño del recorrido y la integración de los recursos fueron realizados para este proyecto.


## 📄 Nota sobre licencias

Este proyecto utiliza recursos de terceros obtenidos desde la Unity Asset Store. Los derechos de las texturas, imágenes, modelos, materiales y prefabs pertenecen a sus respectivos autores.

Antes de reutilizar o redistribuir cualquiera de estos recursos, se deben consultar las condiciones de licencia del paquete correspondiente.



## 📁 Estructura principal

```text
Assets/
├── Animations/
├── Materials/
├── Models/
├── Prefabs/
├── Scenes/
├── Scripts/
│   ├── Interaction/
│   └── Player/
├── Textures/
└── UI/

Packages/
ProjectSettings/

