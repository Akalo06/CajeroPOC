# Cajero POC

## Descripción del proyecto
- **Idea general:** Aplicación tipo cajero para un restaurante de comida rápida que permite gestionar pedidos, generar facturas con código QR, controlar el estado de los pedidos y gestionar usuarios con roles.
- **Problema que resuelve:** Optimiza el flujo de pedidos en un restaurante, evitando errores manuales, llevando un control de productos vendidos y permitiendo generar tickets fiscales.
- **Público objetivo:** Restaurantes de comida rápida, especialmente cadenas que necesiten un control digital de pedidos y facturación.

## Funcionalidades principales
- Gestión de pedidos (añadir productos, confirmar, marcar como listos).
- Pantalla de control de pedidos en preparación y finalizados.
- Generación de facturas tipo ticket térmico.
- Impresión de tickets.
- Gestión de usuarios con roles (Administrador, Cajero).
- Reloj en tiempo real y visualización del usuario actual.
- Persistencia de datos de usuarios mediante archivo JSON.

## Tecnologías utilizadas
- **C# / .NET 8.0:** Lógica de la aplicación.
- **WPF:** Interfaz gráfica de escritorio.
- **JSON:** Persistencia de usuarios y datos de configuración.
- **PrintDialog de WPF:** Impresión de tickets.
- **SpeechSynthesizer:** Aviso sonoro de pedidos listos.
- **GitHub:** Control de versiones y repositorio del proyecto.

## Estado actual del proyecto
- Funcionalidad básica de gestión de pedidos y usuarios implementada.
- Generación e impresión de tickets térmicos funcional.
- Persistencia de usuarios con JSON implementada.
- Interfaz gráfica operativa.
- Algunas funcionalidades avanzadas pendientes: integración con base de datos, código QR en tickets, mejora estética del ticket.
