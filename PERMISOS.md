# Permisos y licencias

## Permisos y autorizaciones
- Uso de librerías estándar de .NET y WPF.
- Licencias de uso de SpeechSynthesizer integradas en Windows.
- Posible integración futura con APIs externas (QR, impresoras).

## Identificación de riesgos
- Uso indebido de datos de usuarios.
- Impresoras no compatibles con ticket térmico.
- Fallos de impresión por falta de permisos.

## Plan básico de prevención de riesgos
- Validar roles de usuarios antes de permitir cambios críticos.
- Probar compatibilidad de impresoras térmicas.
- Guardar copias de seguridad de datos JSON.
- Implementar mensajes de error claros para problemas de permisos.
