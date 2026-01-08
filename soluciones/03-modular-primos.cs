// Bloque principal de ejecución, va primero
Main {
    writeLine("Hola Primos");

    
    writeLine("Primeros 100 números primos");
    // DAW no soporta parámetros por defecto en la llamada, se pasa el argumento requerido (50000)
    printFirstPrimeNumbers(50000); 
    
    writeLine("Primeros 50 números primos gemelos");
    // Se pasa el argumento requerido (5000)
    printFirstTwinPrimeNumbers(100); 
    
}

// ----------------------------------------------------
// FUNCIONES Y PROCEDIMIENTOS AUXILIARES
// ----------------------------------------------------

// Procedimiento que imprime los primeros 'number' números primos
procedure printFirstPrimeNumbers(int number=100) {
    var count = 0; // Se infiere int
    var i = 2;     // Se infiere int
    
    while (count < number) {
        if (isPrime(i)) {
            // Concatenación de string y var
            writeLine((count + 1) + ": " + i);
            count = count + 1; // Equivalente a count++
        }
        i = i + 1; // Equivalente a i++
    }
}

// Procedimiento que imprime los primeros 'number' números primos gemelos
procedure printFirstTwinPrimeNumbers(int number=100) {
    var count = 0;
    var i = 2;
    
    while (count < number) {
        if (areTwinPrimeNumbers(i)) {
            // Concatenación para imprimir la pareja (i, i+2)
            writeLine((count + 1) + ": " + i + ", " + (i + 2));
            count = count + 1;
        }
        i = i + 1;
    }
}

// Procedimiento que imprime números primos gemelos en un rango
procedure printTwinPrimeNumbersInRange(int start=2, int end=100) {
    // Bucle for estándar en DAW
    for (int i = start; i <= end; i = i + 1) {
        if (areTwinPrimeNumbers(i)) {
            writeLine(i + ", " + (i + 2));
        }
    }
}

// Función sobrecargada: comprueba si num y num+2 son gemelos
function boolean areTwinPrimeNumbers(int num) {
    // Llama a la versión sobrecargada de dos parámetros
    return areTwinPrimeNumbers(num, num + 2);
}

// Función sobrecargada: comprueba si dos números son primos gemelos
function boolean areTwinPrimeNumbers(int num1, int num2) {
    // Se asume la existencia de Math.abs() para el valor absoluto
    return isPrime(num1) && isPrime(num2) && Math.abs(num1 - num2) == 2;
}


// Función que comprueba si un número es primo
function boolean isPrime(int num) {
    // Equivalente a la estructura 'when' de Kotlin usando if-else if-else
    if (num == 0 || num == 1) { 
        return false;
    } 
    else if (num == 2 || num == 3) { 
        return true;
    } 
    else { 
        if (num % 2 == 0) {
            return false;
        }
        
        // El cálculo de la raíz cuadrada requiere casting explícito
        // 1. Casting de 'int' a 'decimal' (por ampliación, se exige casting)
        // 2. Uso de la función Math.sqrt()
        // 3. Casting del resultado 'decimal' a 'int' (por reducción, se exige casting)
        int sqrtNum = (int)Math.sqrt((decimal)num);
        
        // Bucle for con incremento de 2 (step 2)
        for (int i = 3; i <= sqrtNum; i = i + 2) {
            if (num % i == 0) {
                return false;
            }
        }
        
        return true;
    }
}