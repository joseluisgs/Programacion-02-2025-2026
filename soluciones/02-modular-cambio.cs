// Bloque principal de ejecución
Main {
    writeLine("Hola Cambio"); // Salida
    
    // Llamada a función
    decimal cantidad = leerCantidad();
    
    // Llamada a procedimiento
    cambioMonedas(cantidad); 
}

// Función auxiliar para leer y validar un valor decimal positivo
function decimal leerCantidad() {
    writeLine("Introduce la cantidad a cambiar:");
    decimal cantidad = 0.0;
    var isSaldoInvalido = true;
    
    do {
        try {
            cantidad = readLine(); // Lectura de entrada
            if (cantidad > 0) {
                isSaldoInvalido = false; // Saldo válido
            } else {
                writeLine("Error: La cantidad debe ser positiva. Inténtalo de nuevo:");
            }
        } catch (Exception e) {
            writeLine("Error: Entrada no válida. Por favor, introduce un número decimal:");
        }
    } while (isSaldoInvalido);

}

// Procedimiento para calcular y mostrar el cambio de monedas
procedure cambioMonedas(decimal cantidad) {
    // 1. Conversión a céntimos (int), que requiere casting explícito.
    // Redondeamos para evitar errores de coma flotante, asumiendo un método de redondeo (round) existe.
    // Usaremos (int) para truncar, como hace (toInt()) en el original para simplificar.
    int cantidadCentimos = (int)(cantidad * 100); 

    // 2. Definición de Constantes de Moneda
    // Se usa la convención MAYUSCULAS_CON_GUIONES para constantes.
    const int MONEDA_2_EURO = 200;
    const int MONEDA_1_EURO = 100;
    const int MONEDA_50_CENT = 50;
    const int MONEDA_20_CENT = 20;
    const int MONEDA_10_CENT = 10;
    const int MONEDA_5_CENT = 5;
    const int MONEDA_2_CENT = 2;
    const int MONEDA_1_CENT = 1;
    
    // 3. Variable mutable para el resto
    var resto = cantidadCentimos; // Se infiere que es int

    writeLine("Cambio en monedas:");
    
    // 4. Lógica de cambio usando condicionales y el operador módulo (%).
    
    if (resto >= MONEDA_2_EURO) {
        int monedas2Euro = resto / MONEDA_2_EURO;
        resto = resto % MONEDA_2_EURO; // Operador módulo
        writeLine(monedas2Euro + " moneda(s) de 2€");
    }
    
    if (resto >= MONEDA_1_EURO) {
        int monedas1Euro = resto / MONEDA_1_EURO;
        resto = resto % MONEDA_1_EURO;
        writeLine(monedas1Euro + " moneda(s) de 1€");
    }
    
    if (resto >= MONEDA_50_CENT) {
        int monedas50Cent = resto / MONEDA_50_CENT;
        resto = resto % MONEDA_50_CENT;
        writeLine(monedas50Cent + " moneda(s) de 50c");
    }
    
    if (resto >= MONEDA_20_CENT) {
        int monedas20Cent = resto / MONEDA_20_CENT;
        resto = resto % MONEDA_20_CENT;
        writeLine(monedas20Cent + " moneda(s) de 20c");
    }
    
    if (resto >= MONEDA_10_CENT) {
        int monedas10Cent = resto / MONEDA_10_CENT;
        resto = resto % MONEDA_10_CENT;
        writeLine(monedas10Cent + " moneda(s) de 10c");
    }
    
    if (resto >= MONEDA_5_CENT) {
        int monedas5Cent = resto / MONEDA_5_CENT;
        resto = resto % MONEDA_5_CENT;
        writeLine(monedas5Cent + " moneda(s) de 5c");
    }
    
    if (resto >= MONEDA_2_CENT) {
        int monedas2Cent = resto / MONEDA_2_CENT;
        resto = resto % MONEDA_2_CENT;
        writeLine(monedas2Cent + " moneda(s) de 2c");
    }
    
    // El resto restante es la cantidad de monedas de 1 céntimo.
    if (resto >= MONEDA_1_CENT) { 
        int monedas1Cent = resto;
        writeLine(monedas1Cent + " moneda(s) de 1c");
    }
}

