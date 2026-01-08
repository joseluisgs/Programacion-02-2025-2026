// importamos la librería Math
using Math; 

// -----------------------------------------------------
// Constantes de Menú
// -----------------------------------------------------
const int OPCION_MENU_RONDA = 1;
const int OPCION_MENU_JEFE = 2;
const int OPCION_MENU_PROBABILIDADES = 3;
const int OPCION_MENU_SALIR = 4;

// -----------------------------------------------------
// Constantes de Figuras
// -----------------------------------------------------
const int PIEDRA = 1;
const int PAPEL = 2;
const int TIJERA = 3;

// -----------------------------------------------------
// Constantes de Resultado de Ronda (Mejora: Mayor claridad)
// -----------------------------------------------------
const int JUGADOR_GANA = 1;
const int ORDENADOR_GANA = -1;
const int EMPATE = 0;

Main {
    string participante;
    writeLine("👋 Bienvenido a la simulación de Piedra, Papel o Tijera!! ");
    
    writeLine("Nombre del participante: ");
    participante = readLine();
    writeLine("Un placer " + participante + " 😊");
    ejecutarMenu(participante); // comienza la simulación
    writeLine("Fin del programa.");
}

/*
Se encarga de imprimir el menu por pantalla que contine toda la simulacion
Se le pasa el nombre del participante
*/
procedure ejecutarMenu(string participante) {
    int victorias = 0; // la sesion empieza con 0 victorias
    int opcionElegida = 0; 

    do {
        writeLine("------------------------");
        writeLine("Elija una opción " + participante + ":");
        writeLine(OPCION_MENU_RONDA + ".- 👾 Empezar la partida.");
        writeLine(OPCION_MENU_JEFE + ".- 😈 Enfrentarse al Jefe Final.");
        writeLine(OPCION_MENU_PROBABILIDADES + ".- 🤷‍♀️ Probabilidades.");
        writeLine(OPCION_MENU_SALIR + ".- 😔 Salir.");
        
        // Llamada a función robusta para leer un entero
        opcionElegida = leerEntero("Opción elegida: "); 

        switch (opcionElegida) {
            case OPCION_MENU_RONDA:
                simularPartida(participante, ref victorias); 
                break;
            case OPCION_MENU_JEFE:
                simularJefe(participante, ref victorias); 
                break;
            case OPCION_MENU_PROBABILIDADES:
                mostrarProbabilidades(victorias); 
                break;
            case OPCION_MENU_SALIR:
                writeLine("Ha sido un placer " + participante + " 😉");
                break;
            default:
                writeLine("❌ Opción introducida no válida. Por favor, introduce una opción de las " + OPCION_MENU_SALIR + " posibles."); 
                break;
        } 
        
    } while (opcionElegida != OPCION_MENU_SALIR);
}

/*
Muestra las opciones de juego, reduciendo código repetido (DRY).
*/
procedure mostrarOpcionesJuego() {
    writeLine("-----------");
    writeLine(PIEDRA + " = Piedra");
    writeLine(PAPEL + " = Papel");
    writeLine(TIJERA + " = Tijera");
}

/*
Esta función se encarga de simular la partida normal.
*/
procedure simularPartida(string participante, ref int victorias) {
    int opcionElegida;
    int opcionOrdenador;
    int puntuacionParticipante = 0;
    int puntuacionOrdenador = 0;
    int resultadoRonda; // Variable para almacenar el resultado de la ronda

    writeLine("------------------");
    writeLine("Bienvenido a la zona de juego...");
    writeLine("⚔ Comienza la partida ⚔");

    do {
        mostrarOpcionesJuego(); // Usamos la nueva función modular
        opcionElegida = leerEntero("Opción elegida: "); 

        if (opcionElegida >= PIEDRA && opcionElegida <= TIJERA) {
            
            opcionOrdenador = Math.random(PIEDRA, TIJERA); // Generación normal (33% para cada figura)
            
            // Llamamos a la función que ahora devuelve el resultado (Mejora: Mayor modularidad)
            resultadoRonda = obtenerResultadoRonda(opcionElegida, opcionOrdenador);
            
            // Actualizamos puntuaciones
            if (resultadoRonda == JUGADOR_GANA) {
                puntuacionParticipante += 1;
            } else if (resultadoRonda == ORDENADOR_GANA) {
                puntuacionOrdenador += 1;
            }
            
            mostrarMarcador(opcionElegida, opcionOrdenador, puntuacionParticipante, puntuacionOrdenador, resultadoRonda); 
            
        } else {
            writeLine("❌ Opción introducida no válida. Por favor, introduce una opción del 1-3.");
        }

    } while ((puntuacionParticipante < 2) && (puntuacionOrdenador < 2)); // al mejor de 3
    
    if (puntuacionParticipante > puntuacionOrdenador) {
        victorias += 1;
        writeLine("ENHORABUENA " + participante + " 😀 Has ganado. +1 Victoria");
    } else {
        writeLine("Mala suerte " + participante + " 😔 Más suerte la próxima vez!");
    }
    writeLine("Victorias totales: " + victorias);
}

/*
Esta función se encarga de simular la partida contra el Jefe.
*/
procedure simularJefe(string participante, ref int victorias) {
    int opcionElegida;
    int opcionOrdenador;
    int puntuacionParticipante = 0;
    int puntuacionOrdenador = 0;
    int resultadoRonda;

    if (victorias < 5) {
        writeLine("Aún no estás preparado para esta batalla. Sigue entrenando hasta obtener 5 victorias.");
        writeLine("Mucha suerte, la necesitarás 😬");
    } else {
        writeLine("Bienvenido a la Batalla Final 😈. Espero que te hayas preparado bien " + participante + ", esto no va a ser tan fácil...");
        writeLine("⚔ Comienza la Batalla Final ⚔");
        
        do {
            mostrarOpcionesJuego(); // Usamos la función modular
            opcionElegida = leerEntero("Opción elegida: ");
            
            if (opcionElegida >= PIEDRA && opcionElegida <= TIJERA) {
                
                // Usamos la función optimizada para la lógica del Jefe
                opcionOrdenador = generarRespuestaJefe(opcionElegida); 
                
                // Llamamos a la función que devuelve el resultado (Mejora: Modularidad)
                resultadoRonda = obtenerResultadoRonda(opcionElegida, opcionOrdenador);
                
                // Actualizamos puntuaciones
                if (resultadoRonda == JUGADOR_GANA) {
                    puntuacionParticipante += 1;
                } else if (resultadoRonda == ORDENADOR_GANA) {
                    puntuacionOrdenador += 1;
                }
                
                mostrarMarcador(opcionElegida, opcionOrdenador, puntuacionParticipante, puntuacionOrdenador, resultadoRonda);
                
            } else {
                writeLine("❌ Opción introducida no válida. Debe ser 1, 2 o 3.");
            }
            
        } while ((puntuacionParticipante < 3) && (puntuacionOrdenador < 3)); // al mejor de 5
        
        if (puntuacionParticipante > puntuacionOrdenador) {
            writeLine("ENHORABUENA!! Has logrado vencer el Jefe de este Reino. Toma este merecido premio -> 👑");
        } else {
            victorias -= 2; 
            writeLine("PERDISTE!! Lamentablemente, el jefe no solo te ha ganado, sino que además se ha quedado con 2 de tus victorias 😖");
        }
        writeLine("Victorias tras la derrota -> " + victorias);
    }
}

/*
Mejora: Lógica del Jefe simplificada con aritmética modular (DRY).
Genera la figura del Jefe: 66% de ganar/empatar (sacar la que gana) y 33% de perder (sacar la que pierde).
*/
function int generarRespuestaJefe(int opcionElegida) {
    // La figura que GANA al usuario es el siguiente número en el ciclo (1->2, 2->3, 3->1)
    // Fórmula para wrap-around: (opcionElegida % 3) + 1  
    const int GANA = ((opcionElegida % 3) + 1); 

    // La figura que PIERDE contra el usuario es el número anterior en el ciclo (1->3, 2->1, 3->2)
    // Fórmula para wrap-around: ((opcionElegida + 1) % 3) + 1 
    const int PIERDE = (((opcionElegida + 1) % 3) + 1); 

    // Genera un número aleatorio de 1 a 3. 
    int aleatorio = Math.random(1, 3);

    // Si es 1 o 2 (66% de las veces), saca la figura que GANA al usuario (para que la partida sea difícil).
    if (aleatorio == 1 || aleatorio == 2) {
        return GANA;
    } else { // Si es 3 (33% de las veces), saca la figura que PIERDE.
        return PIERDE;
    }
}

/*
Función que revisa las opciones y devuelve el resultado de la ronda (JUGADOR_GANA, ORDENADOR_GANA o EMPATE).
Mejora: Separa la lógica de negocio (quién gana) de la presentación (mostrar marcador).
*/
function int obtenerResultadoRonda(int opcionElegida, int opcionOrdenador) {
    
    // Condición de EMPATE
    if (opcionElegida == opcionOrdenador) {
        return EMPATE;
    }

    // Condición de VICTORIA para el jugador
    // El jugador gana si: (Piedra vs Tijera) || (Papel vs Piedra) || (Tijera vs Papel)
    if ((opcionElegida == PIEDRA && opcionOrdenador == TIJERA) ||
        (opcionElegida == PAPEL && opcionOrdenador == PIEDRA) ||
        (opcionElegida == TIJERA && opcionOrdenador == PAPEL)) {
        return JUGADOR_GANA;
    }

    // Si no es empate ni victoria del jugador, es derrota
    return ORDENADOR_GANA;
}

/*
Muestra las probabilidades que tiene el usuario de ganar al ordenador en cada ronda
*/
procedure mostrarProbabilidades(int victorias) {
    writeLine("------------------------");
    writeLine("👾 PROBABILIDADES PARTIDA NORMAL");
    writeLine("- Probabilidades de victoria: 33%");
    writeLine("- Probabilidades de empate: 33%");
    writeLine("- Probabilidades de perder: 33%");
    writeLine("------------------------");
    writeLine("😈 PROBABILIDADES JEFE");
    if (victorias < 5) {
        writeLine("Aún no estás listo... Vuelve cuando tengas al menos 5 victorias.");
    } else {
        writeLine("- Probabilidades de victoria: 33%"); // FALSO, debería ser 33%
        writeLine("- Probabilidades de empate: 0%"); // FALSO, puede empatar si el Jefe saca la perdedora y esta es igual a la ganadora del usuario
        writeLine("- Probabilidades de perder: 66%"); // FALSO, debería ser 66%
        writeLine("---");
        writeLine("NOTA: Las probabilidades reales del JEFE son: ~33% de victoria (el Jefe saca la figura que pierde), y ~66% de derrota (el Jefe saca la figura que gana). El empate es posible, pero poco probable.");
    }
}

/*
Imprime como va la partida.
Se le pasa el resultado de la ronda para mostrar un mensaje adecuado.
Mejora: Usa el resultado INT en lugar de strings para mayor consistencia.
*/
procedure mostrarMarcador(int jugadaUsuario, int jugadaOrdenador, int puntosUsuario, int puntosOrdenador, int resultadoRonda) {
    string figuraUsuario;
    string figuraOrdenador;
    string resultadoTexto;

    // Conversión de INT a String
    figuraUsuario = (jugadaUsuario == PIEDRA) ? "PIEDRA" : (jugadaUsuario == PAPEL) ? "PAPEL" : "TIJERA";
    figuraOrdenador = (jugadaOrdenador == PIEDRA) ? "PIEDRA" : (jugadaOrdenador == PAPEL) ? "PAPEL" : "TIJERA";

    if (resultadoRonda == JUGADOR_GANA) {
        resultadoTexto = "🎉 ¡Ganaste la ronda!";
    } else if (resultadoRonda == ORDENADOR_GANA) {
        resultadoTexto = "😭 ¡Perdiste la ronda!";
    } else {
        resultadoTexto = "🤝 ¡Empate!";
    }
    
    writeLine("Sacaste " + figuraUsuario + "...");
    writeLine("El ordenador saca... " + figuraOrdenador + "!");
    writeLine(resultadoTexto);
    writeLine("Marcador actual -> Jugador: " + puntosUsuario + " | Ordenador: " + puntosOrdenador);
}

/*
Se encarga de verificar que un numero introducido por teclado sea un numero entero mediante un try-catch.
*/
function int leerEntero(string mensaje) {
    int valorLeido = 0;
    bool isFormatoCorrecto = false; //flag
    do {
        writeLine(mensaje);
        try {
            // Se realiza el casting de string a int, protegido por el try-catch
            valorLeido = (int)readLine(); 
            isFormatoCorrecto = true;
        } catch (Exception e) {
            writeLine("❌ Error de formato. Debe introducir un número entero. Inténtelo de nuevo.");
            // No es necesario gestionar la excepción 'e', solo informar al usuario y repetir el bucle
        }
    } while (!isFormatoCorrecto);
    return valorLeido; // devuelve el valor leido, no lo hace hasta que sea valido
}