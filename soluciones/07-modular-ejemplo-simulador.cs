// Bloque principal de ejecución, va primero
Main {
    writeLine("Simulador de Vuelo");
    
    // Variables inicializadas a 0 (se infiere tipo int)
    var velocidadCrucero = 0;
    var altitudCrucero = 0;
    var velocidadActual = 0;
    var altitudActual = 0;
    var temporizador = 0;
    var hayFalloSistema = false; // Se infiere tipo boolean
    
    // Constantes (int para tiempo/límite)
    const int TIEMPO_MAX = 300;
    const int TIEMPO_ESPERA = 200;
    const int PROBABILIDAD_FALLO_SISTEMA = 20; // 20%
    
    // Lectura de entrada
    velocidadCrucero = leerEntero("Introduzca la Velocidad de Crucero: ");
    altitudCrucero = leerEntero("Introduzca la Altitud de Crucero: ");

    // Inicialización de variables
    velocidadActual = velocidadCrucero;
    altitudActual = altitudCrucero;

    writeLine("Comenzando el vuelo");
    writeLine("Velocidad Actual: " + velocidadActual);
    writeLine("Altitud Actual: " + altitudActual);
    writeLine("Velocidad Crucero: " + velocidadCrucero);
    writeLine("Altitud Crucero: " + altitudCrucero);

    do {
        writeLine("Obteniendo datos");
        velocidadActual = getDatosActualesVelocidad(velocidadActual);
        altitudActual = getDatosActualesAltitud(altitudActual);
        writeLine("Velocidad Actual: " + velocidadActual);
        writeLine("Altitud Actual: " + altitudActual);

        writeLine("Aplicando correcciones");
        // El paso de argumentos int -> int no requiere casting [cite: 2025-10-07]
        velocidadActual = correccionVelocidad(velocidadCrucero, velocidadActual);
        altitudActual = correccionAltitud(altitudCrucero, altitudActual);

        writeLine("Velocidad Actual: " + velocidadActual);
        writeLine("Altitud Actual: " + altitudActual);

        hayFalloSistema = probabilidad(PROBABILIDAD_FALLO_SISTEMA);
        temporizador = temporizador + 10;
        
        esperar(TIEMPO_ESPERA);
        
        writeLine("Tiempo de Vuelo: " + temporizador);
        
    } while (temporizador <= TIEMPO_MAX && !hayFalloSistema);

    if (hayFalloSistema) {
        writeLine("Volviendo a control manual porque ha habido un fallo en el sistema");
    } else {
        writeLine("Volviendo a control manual porque ha terminado el tiempo");
    }
}

// ----------------------------------------------------
// FUNCIONES Y PROCEDIMIENTOS AUXILIARES
// ----------------------------------------------------

// Función que lee y valida un entero no negativo
function int leerEntero(string mensaje) {
    writeLine(mensaje);
    var isOk = false;
    var valor = 0;
    do {
        try {
            valor = (int)readLine(); // Casting explícito de string a int
            if (valor >= 0) {
                isOk = true;
            } else {
                writeLine("Error: debe introducir un número entero no negativo.");
            }
        } catch (FormatException) {
            writeLine("Error: debe introducir un número entero válido.");
        }
    } while (!isOk || valor < 0);
    return valor;
}

// Procedimiento para pausar la ejecución del programa
procedure esperar(int tiempo) {
    sleep(tiempo); 
}

// Funciones que simulan la obtención de datos aleatorios
function int getVelocidadActual() {
    // 1. Math.random() devuelve decimal (0.0 a 1.0)
    // 2. (Math.random() * 20) es decimal
    // 3. (int)(...) es casting explícito a int (truncamiento)
    return (int)(Math.random() * 20) - 10;
}

function int getAltitudActual() {
    return (int)(Math.random() * 20) - 10;
}

// Funciones que obtienen los datos actuales
function int getDatosActualesVelocidad(int velocidadActual) {
    int nuevaVelocidad = velocidadActual + getVelocidadActual();
    // Operador condicional ternario: no disponible en DAW. Usamos if-else.
    if (nuevaVelocidad < 0) {
        return 0;
    } else {
        return nuevaVelocidad;
    }
}

function int getDatosActualesAltitud(int altitudActual) {
    int nuevaAltitud = altitudActual + getAltitudActual();
    if (nuevaAltitud < 0) {
        return 0;
    } else {
        return nuevaAltitud;
    }
}

// Funciones que aplican correcciones
function int correccionVelocidad(int velocidadCrucero, int velocidadActual) {
    if (velocidadActual < velocidadCrucero) {
        return velocidadActual + 1;
    } else {
        return velocidadActual - 1;
    }
}

function int correccionAltitud(int altitudCrucero, int altitudActual) {
    if (altitudActual < altitudCrucero) {
        return altitudActual + 1;
    } else {
        return altitudActual - 1;
    }
}

// Función que calcula si hay fallo (límite es un porcentaje de 1 a 100)
function boolean probabilidad(int limite) {
    // Generamos un entero aleatorio entre 1 y 100 (inclusivo)
    int randomInt = (int)(Math.random() * 100) + 1; 
    return randomInt <= limite;
}