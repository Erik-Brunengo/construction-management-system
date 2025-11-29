Este proyecto es una aplicación de consola desarrollada en C# (.NET) que simula la operatoria de 
una empresa constructora ("Todo Terreno"). 
El objetivo principal fue digitalizar la administración de recursos, permitiendo gestionar obras en 
ejecución, personal (obreros y jefes) y la asignación eficiente de grupos de trabajo.

Integrantes del Equipo:
-Erik Brunengo
-Gael Tadeo Ferreira
-Agustina Victoria Contartese


Funcionalidades Principales: El sistema permite realizar el ciclo completo de administración:

Gestión de Recursos Humanos: Contratación y despido de obreros y Jefes de Obra, asignando
roles específicos (capataz, albañil, etc.).

Gestión de Proyectos: Creación de nuevas obras (remodelación, construcción, etc.) y 
control de su estado de avance (0-100%).

Lógica de Negocio: Asignación inteligente de "Jefes" a obras y "Grupos de Obreros" a
tareas específicas, validando disponibilidad.

Reportes: Submenú de impresión para listar estados de obras, costos y personal activo.

Tecnologías y Conceptos Aplicados: Este proyecto fue diseñado para consolidar conceptos 
avanzados de programación:

Programación Orientada a Objetos (POO): Uso extensivo de Clases y Objetos.

Herencia: Implementación de jerarquías (ej. JefeDeObra hereda de Obrero).

Colecciones: Uso de ArrayList para el manejo dinámico de listas.

Manejo de Errores: Implementación de Try/Catch y excepciones personalizadas para 
validar reglas de negocio (ej. no asignar un grupo ocupado).

Diagramado UML: Diseño previo de la arquitectura de clases.
