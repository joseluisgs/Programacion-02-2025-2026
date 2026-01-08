Main {
    // DECLARACIÓN DE VARIABLES
    decimal saldo;
    decimal saldoApostado;
    decimal saldoAñadido;
    int opcionMenu = 0; // Inicializar para garantizar que el 'do-while' entre la primera vez
    int numeroAleatorio1;
    int numeroAleatorio2;
    int numeroAleatorio3;
    
    // Bandera para la validación inicial, aunque se puede simplificar
    bool isSaldoInvalido; 
    bool isSaldoAñadidoNegativo;

    writeLine("Simulación de Máquina Tragaperras");
    
    // --- 1. SOLICITAR SALDO INICIAL ---
    do {
        writeLine("Introduce el saldo inicial (mínimo 0.50€): ");
        // Aseguramos el casting explícito
        saldo = (decimal)readLine(); 
        
        if (saldo < 0.50m) { // Usar 'm' para literal decimal
            writeLine("Saldo inferior a 0.50€. Por favor, introduzca un valor superior o igual.");
            isSaldoInvalido = true;
        } else {
            writeLine("Saldo inicial: " + saldo + "€");
            isSaldoInvalido = false;
        }
    } while (isSaldoInvalido); 

    // --- 2. BUCLE PRINCIPAL (DO-WHILE: se ejecuta al menos una vez) ---
    do {
        writeLine("-----------------------------------------------------------");
        writeLine("Saldo actual: " + saldo + "€");
        writeLine("Introduzca el número de la opción que desee llevar acabo:");
        writeLine("1. Tirar de la tragaperras.");
        writeLine("2. Añadir saldo.");
        writeLine("3. Salir.");
        opcionMenu = (int)readLine(); 

        switch (opcionMenu) {
            case 1:
                // --- BUCLE DE APUESTA (VALIDACIÓN DE INPUT) ---
                do { 
                    writeLine("¿Cuánto dinero quiere apostar a esta tirada? (Mínimo 0.50€): ");
                    saldoApostado = (decimal)readLine();
                    
                    if (saldoApostado < 0.50m || saldoApostado > saldo) {
                        writeLine("Entrada de datos inválida. Recuerde que la apuesta mínima es de 0.50€ y la máxima es su saldo.");
                    } else {
                        // Descontar saldo y generar números
                        saldo -= saldoApostado;
                        // Corregido: Si es entre 0 y 9, es (0, 9). Si es entre 1 y 9, es (1, 9). Mantenemos 0-9 por la naturaleza de las tragaperras.
                        numeroAleatorio1 = Math.random(0, 9); 
                        numeroAleatorio2 = Math.random(0, 9);
                        numeroAleatorio3 = Math.random(0, 9);
                        
                        writeLine("Máquina: " + numeroAleatorio1 + " | " + numeroAleatorio2 + " | " + numeroAleatorio3);
                        
                        // --- LÓGICA DE PREMIOS (CORREGIDA CON && y ||) ---
                        
                        // CASO 1: TRES IGUALES (Gran Premio: 2x lo apostado)
                        if ((numeroAleatorio1 == numeroAleatorio2) && (numeroAleatorio2 == numeroAleatorio3)) {
                            saldo += 3 * saldoApostado; // Ganancia neta de 2x, se devuelve la apuesta (1x) + el doble de premio (2x)
                            writeLine("!! ENHORABUENA !! TRES EN RAYA.");
                            writeLine("Ganas el triple (x3). Saldo total: " + saldo + "€");
                            
                        // CASO 2: DOS IGUALES (Premio Menor: se devuelve lo apostado)
                        } else if (
                            // Caso A: N1 == N2 y N2 != N3
                            ((numeroAleatorio1 == numeroAleatorio2) && (numeroAleatorio2 != numeroAleatorio3)) || 
                            // Caso B: N1 == N3 y N1 != N2
                            ((numeroAleatorio1 == numeroAleatorio3) && (numeroAleatorio1 != numeroAleatorio2)) || 
                            // Caso C: N2 == N3 y N2 != N1
                            ((numeroAleatorio2 == numeroAleatorio3) && (numeroAleatorio2 != numeroAleatorio1))
                        ) { 
                            saldo += saldoApostado; // Se devuelve la apuesta, saldo queda igual al inicio de la tirada
                            writeLine("Dinero apostado devuelto (x1).");
                            writeLine("Tu saldo es de: " + saldo + "€");
                            
                        // CASO 3: NADA IGUAL (Pérdida)
                        } else { 
                            // Saldo ya se descontó antes del IF
                            writeLine("Más suerte la próxima.");
                            writeLine("Tu saldo es de: " + saldo + "€");
                        }
                    }
                } while (saldoApostado < 0.50m || saldoApostado > saldo);
                break;
                
            case 2:
                do {
                    writeLine("¿Cuánto quieres añadir?: ");
                    saldoAñadido = (decimal)readLine();
                    if (saldoAñadido < 0.0m) {
                        writeLine("No se acepta dinero negativo.");
                        isSaldoAñadidoNegativo = true;
                    } else {
                        saldo += saldoAñadido;
                        writeLine("Saldo final: " + saldo + "€");
                        isSaldoAñadidoNegativo = false;
                    }
                } while (isSaldoAñadidoNegativo);
                break;
                
            case 3:
                writeLine("Ha sido un placer. ¡Vuelva pronto!");
                break;
                
            default:
                writeLine("Opción no válida. Por favor, elija 1, 2 o 3.");
                break;
        }
    // El juego continúa si NO ha elegido salir (3) Y le queda saldo para apostar.
    } while (opcionMenu != 3 && saldo >= 0.50m); 

    // --- FIN DEL PROGRAMA ---
    writeLine("Fin del programa. Saldo final: " + saldo + "€");
}