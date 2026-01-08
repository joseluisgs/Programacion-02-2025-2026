/*
PROGRAMA: Máquina Tragaperras (Versión Final Compatible con DAW)
DESCRIPCIÓN: Simulación de una máquina tragaperras con gestión de saldo
             y premios. Implementa el Principio de Responsabilidad Única (SRP)
             y usa constantes para mejorar la legibilidad del menú.
*/
using Math; // Importamos la librería Math (para Math.random)

// ==============================================================================
// 1. CONSTANTES GLOBALES (Reglas de Negocio)
// ==============================================================================
const decimal APUESTA_MINIMA = 0.01; 
const int JACKPOT_NUM = 7; 

// Multiplicadores de Premio
const int PREMIO_JACKPOT_MULT = 10;
const int PREMIO_TRES_IGUALES_MULT = 3;
const decimal PREMIO_DOS_IGUALES_MULT = 1.5; 

// ==============================================================================
// 2. CONSTANTES PARA EL MENÚ PRINCIPAL (Sustituyen al ENUM)
// Mantiene la legibilidad del código sin usar el tipo ENUM asociado a valor.
// ==============================================================================
const int OPCION_MENU_TIRAR = 1;
const int OPCION_MENU_GESTIONAR = 2;
const int OPCION_MENU_PREMIOS = 3;
const int OPCION_MENU_SALIR = 4; // También usada como número total de opciones

// ==============================================================================
// 3. CONSTANTES PARA EL MENÚ DE GESTIÓN DE SALDO (Sustituyen al ENUM)
// ==============================================================================
const int OPCION_GESTION_ANADIR = 1;
const int OPCION_GESTION_RETIRAR = 2;
const int OPCION_GESTION_VOLVER = 3;


// ==============================================================================
// 4. FUNCIONES DE ENTRADA (Lectura Robusta y SRP)
// Su responsabilidad es garantizar el formato correcto.
// ==============================================================================

function int leerEntero(string mensaje) {
    int valorLeido = 0;
    bool formatoCorrecto = false;

    do {
        write(mensaje); // Pista: Usamos 'write' (sin salto de línea, si DAW lo permite)
        try {
            valorLeido = (int)readLine(); 
            formatoCorrecto = true;
        } catch (Exception e) {
            writeLine("❌ Error de formato. Debe introducir un número entero. Inténtelo de nuevo.");
        }
    } while (!formatoCorrecto);

    return valorLeido;
}

function decimal leerDecimal(string mensaje) {
    decimal valorLeido = 0.0m;
    bool formatoCorrecto = false;

    do {
        write(mensaje); // Pista: Usamos 'write' (sin salto de línea)
        try {
            valorLeido = (decimal)readLine(); 
            formatoCorrecto = true;
        } catch (Exception e) {
            writeLine("❌ Error de formato. Debe introducir un número (ej: 10 o 5.50). Inténtelo de nuevo.");
        }
    } while (!formatoCorrecto);

    return valorLeido;
}

// ==============================================================================
// 5. FUNCIÓN DE UTILIDAD Y VALIDACIÓN
// ==============================================================================

// Verifica si un número es estrictamente superior a un umbral.
function bool isSuperiorA(decimal num, decimal umbral) {
    return num > umbral;
}

// ==============================================================================
// 6. FUNCIÓN PRINCIPAL (MAIN)
// ==============================================================================

Main {
    decimal saldo;
    bool isSaldoValido;

    writeLine("🎰 Bienvenido a la Máquina Tragaperras");

    // Bucle para pedir el saldo inicial.
    do {
        writeLine("----------------------");
        saldo = leerDecimal("¿Con cuánto saldo deseas iniciar? (€): ");

        // Validación de la regla de negocio (saldo > 0)
        isSaldoValido = isSuperiorA(saldo, 0.0);
        if (!isSaldoValido) {
            writeLine("❌ Error. La cantidad debe ser superior a 0.00€.");
        }
    } while (!isSaldoValido);

    ejecutarMenu(ref saldo); 
    writeLine("Ha sido un placer, ¡vuelve pronto! 😉"); 
}

// ==============================================================================
// 7. PROCEDIMIENTO PRINCIPAL PARA EL MENÚ DE OPCIONES
// Controla el flujo principal.
// ==============================================================================

procedure ejecutarMenu(ref decimal saldo) {
    int opcionElegida;

    do {
        writeLine("----------------------");
        writeLine("Saldo actual: " + saldo + "€");
        writeLine("Elija una opción:");
        writeLine(OPCION_MENU_TIRAR + ".- Tirar de la tragaperras.");
        writeLine(OPCION_MENU_GESTIONAR + ".- Gestionar saldo.");
        writeLine(OPCION_MENU_PREMIOS + ".- Ver premios.");
        writeLine(OPCION_MENU_SALIR + ".- Salir."); 

        opcionElegida = leerEntero("Opción elegida = ");

        // Ejecución de la opción usando las CONSTANTES (para mayor claridad que los números directos)
        switch (opcionElegida) {
            case OPCION_MENU_TIRAR:
                tirarTragaperras(ref saldo);
                break;
            case OPCION_MENU_GESTIONAR:
                gestionarSaldo(ref saldo);
                break;
            case OPCION_MENU_PREMIOS:
                imprimirListaPremios();
                break;
            case OPCION_MENU_SALIR:
                writeLine("Saliendo del programa...");
                break;
            default:
                writeLine("⚠️ Opción no válida. Introduzca una opción de " + OPCION_MENU_TIRAR + " a " + OPCION_MENU_SALIR + ".");
                break;
        }

        // Revisión de saldo después de una acción (si es 0 o menos, forzamos a Salir/Gestionar)
        if (saldo <= 0.0) {
            writeLine("¡Te has quedado sin saldo! Debes recargar o el juego terminará.");
            
            // Si el saldo es cero y el usuario no está en Gestión de Saldo, lo enviamos allí.
            if (opcionElegida != OPCION_MENU_GESTIONAR) {
                gestionarSaldo(ref saldo); 
            }

            // Si después de gestionar saldo sigue siendo 0.0, forzamos la salida.
            if (saldo <= 0.0) {
                 opcionElegida = OPCION_MENU_SALIR; 
            }
        }

    } while (opcionElegida != OPCION_MENU_SALIR);
}

// ==============================================================================
// 8. PROCEDIMIENTO PARA LA TIRADA DE LA TRAGAPERRAS
// ==============================================================================

procedure tirarTragaperras (ref decimal saldo) {
    decimal saldoApostado;
    bool isApuestaValida;

    // Bucle para validar la apuesta según las reglas de negocio
    do {
        writeLine("----------------------");
        writeLine("Saldo actual: " + saldo + "€");
        
        saldoApostado = leerDecimal("¿Cuánto saldo desea apostar en la tirada?: ");

        // Validar reglas: positiva, no superior al saldo y mayor o igual a la mínima.
        isApuestaValida = isSuperiorA(saldoApostado, 0.0) && (saldoApostado <= saldo) && (saldoApostado >= APUESTA_MINIMA);

        if (!isApuestaValida) {
             if (saldoApostado > saldo) {
                 writeLine("❌ Error. El saldo apostado (" + saldoApostado + "€) no puede ser superior al saldo actual (" + saldo + "€).");
             } else {
                 writeLine("❌ Error. La apuesta mínima es de " + APUESTA_MINIMA + "€.");
             }
        }
    } while (!isApuestaValida);

    // Ejecución de la tirada
    saldo -= saldoApostado;
    
    // Generamos y mostramos la tirada
    int num1 = Math.random(0, 9);
    int num2 = Math.random(0, 9);
    int num3 = Math.random(0, 9);
    writeLine("La tragaperras muestra: " + num1 + " " + num2 + " " + num3);
    
    // Calculamos el premio
    decimal premio = calcularPremio(num1, num2, num3, saldoApostado);
    saldo += premio; 
    writeLine("Saldo actual: " + saldo + "€");
}

// ==============================================================================
// 9. FUNCIÓN QUE CALCULA EL PREMIO (SRP)
// Devuelve el monto del premio a sumar.
// ==============================================================================

function decimal calcularPremio(int n1, int n2, int n3, decimal apuesta) {
    if (n1 == JACKPOT_NUM && n2 == JACKPOT_NUM && n3 == JACKPOT_NUM) {
        writeLine("💰💰 JACKPOT!! 💰💰");
        return PREMIO_JACKPOT_MULT * apuesta;
    } else if (n1 == n2 && n2 == n3) {
        writeLine("🎉 VICTORIA!! Tres números iguales.");
        return PREMIO_TRES_IGUALES_MULT * apuesta;
    } else if (n1 == n2 || n2 == n3 || n1 == n3) {
        writeLine("⭐ SALVADO!! Dos números iguales.");
        return PREMIO_DOS_IGUALES_MULT * apuesta;
    } else {
        writeLine("😞 MALA SUERTE!! Inténtelo de nuevo.");
        return 0.0; 
    }
}

// ==============================================================================
// 10. PROCEDIMIENTOS MODULARES PARA GESTIONAR SALDO (SRP)
// Cada acción (Añadir/Retirar) tiene su propia función con su lógica de validación.
// ==============================================================================

procedure añadirSaldo(ref decimal saldo) {
    decimal saldoIntroducido;
    bool isMontoValido;

    writeLine("----------------------");
    saldoIntroducido = leerDecimal("Saldo a añadir: ");
    
    isMontoValido = isSuperiorA(saldoIntroducido, 0.0m);

    if (!isMontoValido) {
        writeLine("❌ Error. La cantidad a añadir debe ser positiva.");
    } else {
        saldo += saldoIntroducido;
        writeLine("✅ Saldo añadido. Saldo actual: " + saldo + "€");
    }
}

procedure retirarSaldo(ref decimal saldo) {
    decimal saldoIntroducido;
    bool isMontoValido;

    writeLine("----------------------");
    saldoIntroducido = leerDecimal("Saldo a retirar: ");
    
    isMontoValido = isSuperiorA(saldoIntroducido, 0.0m);

    if (!isMontoValido) {
        writeLine("❌ Error. La cantidad a retirar debe ser positiva.");
    } else if (saldoIntroducido > saldo){
        writeLine("❌ Error. No puedes retirar más de lo que tienes. (Máximo: " + saldo + "€)");
    } else {
        saldo -= saldoIntroducido;
        writeLine("✅ Saldo retirado. Saldo actual: " + saldo + "€");
    }
}

// ==============================================================================
// 11. PROCEDIMIENTO GESTOR DE SALDO (Delega la acción)
// Su única responsabilidad es mostrar el menú de gestión y llamar a la función SRP.
// ==============================================================================

procedure gestionarSaldo (ref decimal saldo) {
    int opcionElegida;

    writeLine("----------------------");
    writeLine("Gestión de Saldo. Saldo actual = " + saldo + "€");
    writeLine("¿Qué desea hacer?");
    writeLine(OPCION_GESTION_ANADIR + ".- Añadir saldo.");
    writeLine(OPCION_GESTION_RETIRAR + ".- Retirar saldo.");
    writeLine(OPCION_GESTION_VOLVER + ".- Volver al menú.");

    opcionElegida = leerEntero("Opción elegida = ");

    switch (opcionElegida) {
        case OPCION_GESTION_ANADIR:
            añadirSaldo(ref saldo);
            break;
        case OPCION_GESTION_RETIRAR:
            retirarSaldo(ref saldo);
            break;
        case OPCION_GESTION_VOLVER:
            writeLine("Volviendo al menú principal...");
            break;
        default:
            writeLine("❌ Error. Opción no válida");
            break;
    }
}

// ==============================================================================
// 12. PROCEDIMIENTO PARA IMPRIMIR LA LISTA DE PREMIOS (SRP)
// ==============================================================================

procedure imprimirListaPremios {
    writeLine("----------------------");
    writeLine("🏆 Posibles Premios:");
    writeLine("- **JACKPOT (" + JACKPOT_NUM + " " + JACKPOT_NUM + " " + JACKPOT_NUM + "):** Ganas x" + PREMIO_JACKPOT_MULT + " veces lo apostado.");
    writeLine("- **VICTORIA (3 Iguales, no " + JACKPOT_NUM + "):** Ganas x" + PREMIO_TRES_IGUALES_MULT + " veces lo apostado.");
    writeLine("- **SALVADO (2 Iguales):** Ganas x" + PREMIO_DOS_IGUALES_MULT + " veces lo apostado.");
    writeLine("- **MALA SUERTE (Ninguno igual):** Pierdes el dinero apostado.");
}

