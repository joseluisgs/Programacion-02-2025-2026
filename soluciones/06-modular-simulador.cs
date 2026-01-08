// Bloque principal de ejecución: debe ir primero en DAW
Main {
    // Definición de Constantes (int para tiempo, decimal para probabilidad)
    const int TIEMPO_SIMULACION = 10000; 
    const int INCREMENTO_TIEMPO = 1000;
    // Literal decimal corregido (sin 'm')
    const decimal PROBABILIDAD_ACCION = 0.20; 

    // Definición de Variables (var int para tiempo, var boolean para la salida)
    var tiempo = 0; 
    var salidaPorProbabilidad = false; 

    do {
        // Simular el paso del tiempo, pausa la ejecución
        sleep(INCREMENTO_TIEMPO); 
        
        tiempo = tiempo + INCREMENTO_TIEMPO;
        writeLine("Tiempo: " + tiempo);
        
        // Simular acciones durante el tiempo
        // ... (Comentarios de lógica de negocio omitidos)
        
        // Llamada a función (coincidencia de tipos: decimal -> decimal)
        salidaPorProbabilidad = probabilidad(PROBABILIDAD_ACCION);
        
    } while (tiempo < TIEMPO_SIMULACION && !salidaPorProbabilidad);

    if (salidaPorProbabilidad) {
        writeLine("Se ha salido por probabilidad");
    } else {
        writeLine("Se ha llegado al tiempo de simulación");
    }

    writeLine("Fin de la simulación");
}

// ----------------------------------------------------
// FUNCIONES AUXILIARES
// ----------------------------------------------------

// Función que calcula si un evento ocurre basado en una probabilidad
function boolean probabilidad(decimal probabilidad) {
    // Se asume que Math.random() devuelve un valor decimal entre 0.0 y 1.0 (exclusivo)
    decimal random = Math.random(); 
    return random < probabilidad;
}