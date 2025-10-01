### 50 Ejercicios de Programación Moduar (Lenguaje DAW)

- [50 Ejercicios de Programación Moduar (Lenguaje DAW)](#50-ejercicios-de-programación-moduar-lenguaje-daw)
- [Nivel 1: Fundamentos de Módulos y Reutilización Básica](#nivel-1-fundamentos-de-módulos-y-reutilización-básica)
- [Nivel 2: Módulos con Iteración, Control de Flujo y Reutilización](#nivel-2-módulos-con-iteración-control-de-flujo-y-reutilización)
- [Nivel 3: Paso por Referencia (`ref`), Múltiples Valores (`out`) y `params`](#nivel-3-paso-por-referencia-ref-múltiples-valores-out-y-params)
- [Nivel 4: Diseño Modular Avanzado, Excepciones y Aserciones](#nivel-4-diseño-modular-avanzado-excepciones-y-aserciones)



### Nivel 1: Fundamentos de Módulos y Reutilización Básica

**1. Cálculo de Cuadrado Modular**
Diseñar un programa principal que pida el lado de un cuadrado. Debe llamar a una **función** para calcular y devolver el área, y a otra **función** para calcular y devolver el perímetro.

**2. Cálculo de Círculo Modular**
Diseñar un programa principal que pida el radio. Debe llamar a una **función** para calcular el área y a otra **función** para calcular la circunferencia.

**3. Verificación de Positivo/Negativo**
Crear una **función lógica** (`bool`) que reciba un número entero como argumento y devuelva `verdadero` si es positivo. El programa principal debe usar el resultado para informar si el número es positivo, negativo o cero.

**4. Validación de Raíz Cuadrada Controlada**
Implementar una **función** `CalcularRaiz` que reciba un número y devuelva su raíz cuadrada (utilizando la librería `Math`). Si el número es negativo, la función debe devolver -1. El módulo principal debe interpretar el resultado para informar de la imposibilidad de la operación.

**5. Conversor de Temperatura Bidireccional**
Diseñar una **función** `CentigradosAFarenheit` y otra **función** `FarenheitACentigrados`. El programa principal debe gestionar la entrada de datos, permitiendo al usuario elegir el sentido de la conversión y llamando a la función apropiada.

**6. Cálculo de Precio Final con IVA**
Declarar la constante `IVA_GENERAL` (ej. 21%) globalmente. Crear una **función** `CalcularPrecioFinal` que reciba el precio base de un producto y devuelva el precio final aplicando la tasa de IVA definida.

**7. Determinar Días del Mes (Simple)**
Implementar una **función** `ObtenerDiasMes` que tome el número de mes (1 a 12) y devuelva la cantidad de días que tiene (sin considerar bisiesto), utilizando la estructura `según`/`switch`.

**8. Verificación de Bisiesto**
Crear una **función lógica** `EsBisiesto` que reciba un año y devuelva `verdadero` si cumple la condición de año bisiesto.

**9. Determinar Decimales**
Diseñar una **función lógica** `TieneDecimales` que reciba un número real y devuelva `verdadero` si tiene parte fraccionaria (decimales), utilizando la función de librería `Trunc()` de `Math`.

**10. Saludo Personalizado por Turno**
Crear un **procedimiento** llamado `Saludo` que reciba un nombre y la hora actual (entero, 0-23) y escriba un saludo personalizado, diferenciando entre mañana, tarde y noche, utilizando condicionales anidados.

---

### Nivel 2: Módulos con Iteración, Control de Flujo y Reutilización

**11. Impresión de Pares en Rango**
Crear un **procedimiento** `ImprimirPares` que reciba dos límites (inicio y fin) y utilice un bucle `para` para mostrar todos los números pares en ese rango.

**12. Cálculo de Factorial (Iterativo)**
Diseñar una **función** `CalcularFactorial` que reciba un entero $N$ y calcule su factorial $N!$ utilizando un bucle iterativo (`para`).

**13. Cálculo de Factorial (Recursivo)**
Implementar una **función** `CalcularFactorialRecursivo` que resuelva el factorial llamándose a sí misma (recursividad), definiendo claramente la condición de parada (caso base).

**14. Conteo de Cifras**
Implementar una **función** `ContarCifras` que reciba un número entero y determine cuántas cifras tiene, utilizando un bucle de división sucesiva.

**15. Número Primo Reutilizable**
Crear una **función lógica** `EsPrimo`. El programa principal debe usar esta función para leer un número e indicar si es primo o no.

**16. Listado de Primos**
Reutilizar la **función** `EsPrimo` del ejercicio anterior para crear un **procedimiento** `MostrarPrimosEnRango` que imprima todos los números primos entre 1 y 100.

**17. Cálculo de Retención IRPF Progresiva**
Declarar constantes para umbrales de ingreso y tasas de IRPF. Crear una **función** `CalcularIRPF` que reciba el salario bruto mensual y devuelva la cantidad retenida, utilizando una cadena de condicionales anidados.

**18. Jornal Diario Modular**
Crear una **función** `CalcularTarifaPorHora` que reciba el turno ('D' o 'N') y si es domingo (`bool`), y devuelva la tarifa por hora correspondiente, aplicando las reglas de recargos.

**19. Media Indefinida (Centinela)**
Diseñar una **función** `ObtenerMediaCentinela` que gestione la entrada de una cantidad indefinida de números positivos, deteniéndose cuando se introduce un número negativo (centinela). La función debe devolver la media y la cantidad de números válidos.

**20. Restas Sucesivas (Cociente)**
Diseñar una **función** `ObtenerCociente` que reciba el dividendo y el divisor, y devuelva el cociente entero utilizando restas sucesivas dentro de un bucle `mientras`.

**21. Cálculo de Potencia Iterativa**
Implementar una **función** `CalcularPotencia` que reciba la base $A$ y el exponente $B$ (enteros), y calcule $A^B$ utilizando un bucle.

**22. Diseño Modular de Menú Básico**
Crear un **procedimiento** llamado `MostrarMenu` que imprima 5 opciones (ej. 1. Sumar, 2. Restar, 5. Salir). El Módulo Principal debe usar un bucle `repetir-mientras` para llamar al menú, leer la opción seleccionada, y luego usar la estructura `según` (`switch`) para simplemente mostrar un mensaje que indique **"Ha pulsado la opción X"** antes de volver a mostrar el menú.

**23. Conteo de Aprobados y Suspensos (Indefinido)**
Crear un **procedimiento** `ProcesarNotas` que reciba las notas de alumnos utilizando un bucle controlado por centinela (nota negativa). El módulo debe gestionar y mostrar el conteo de aprobados y suspensos.

---

### Nivel 3: Paso por Referencia (`ref`), Múltiples Valores (`out`) y `params`

**24. Ordenamiento de Tres Números por Referencia**
Escribir un **procedimiento** `OrdenarTresNumeros` que reciba tres números enteros (A, B, C) utilizando **paso por referencia (`ref`)**. El módulo debe modificar los valores originales para que queden ordenados en el módulo principal.

**25. Restas Sucesivas (Doble Resultado)**
Diseñar un **procedimiento** `DividirPorResta` que reciba el dividendo y el divisor. Este módulo debe "devolver" tanto el cociente como el resto, utilizando **parámetros de salida (`out` o `ref`)**.

**26. Conteo de Dígitos Pares e Impares**
Realizar un **procedimiento** `ContarDigitos` que reciba un número y utilice dos **parámetros de salida (`out`)** para devolver la cantidad de dígitos pares y la cantidad de dígitos impares que contiene.

**27. Cálculo de Edad con Múltiples Salidas**
Diseñar un **procedimiento** `CalcularAntiguedad` que reciba la fecha de nacimiento y la fecha actual, y utilice **parámetros de salida** para devolver la edad en años y los meses que han transcurrido desde su último cumpleaños.

**28. Devolución de Monedas (Referencia)**
Crear un **procedimiento** `CalcularCambio` que reciba la cantidad total a devolver. Este módulo debe utilizar **variables por referencia** para almacenar cuántas monedas de 2€, 1€, 50cts, etc., se necesitan.

**29. Validación de Datos con Múltiple Salida**
Escribir un **procedimiento** `ValidarCredenciales` que reciba un nombre de usuario y una contraseña y utilice un **parámetro de salida** para indicar si la validación fue exitosa (`bool`) y otro **parámetro de salida** para devolver un mensaje de error detallado (`string`) en caso de fallo.

**30. Suma de Dígitos (Reutilización por Comparación)**
Crear una **función** `SumaDigitos` que calcule la suma de los dígitos de un número. El programa principal debe reutilizar la función para comparar dos números y determinar cuál tiene la suma de sus dígitos mayor.

**31. Validación de Intervalo con Repetición Forzada**
Diseñar un **procedimiento** `SolicitarNumeroEnRango` que pida un número al usuario. Debe utilizar un bucle `repetir-mientras` para garantizar que el número introducido esté entre 1 y 5.

**32. Manejo de Suma Indeterminada (`params`)**
Crear una **función** `SumarValores` que utilice **parámetros variables (`params`)** para aceptar un número indeterminado de argumentos de tipo entero. La función debe sumar todos los valores pasados y devolver el resultado.

**33. Validación de Entrada con Early Return**
Crear una **función lógica** `ValidarEdad(edad)` que reciba la edad. Usar la técnica de **Salida Anticipada** (`Early Return`) para devolver `falso` inmediatamente si la edad es menor a 0 o mayor a 120.

**34. Parámetros por Defecto y Opcionales (Descuento)**
Crear una **función** `AplicarDescuento` que reciba un precio y un porcentaje de descuento. El porcentaje debe tener un **valor por defecto** (ej. 5%).

**35. Conversión Decimal a Binario Modular**
Implementar una **función** `DecimalABinario` que reciba un número entero decimal y devuelva su representación binaria (como cadena o número muy grande), utilizando la lógica de divisiones sucesivas por 2.

**36. Sobrecarga para Cálculo de Perímetros**
Crear dos **funciones sobrecargadas** llamadas `CalcularPerimetro`: una que reciba un solo lado (para un cuadrado) y otra que reciba largo y ancho (para un rectángulo).

**37. Simulación de Reloj Digital (Actualización por Referencia)**
Diseñar un **procedimiento** `ActualizarHora` que reciba horas, minutos y segundos (todos por `ref`). El módulo debe incrementar el tiempo en un segundo y manejar el "acarreo".

**38. Función InLine con Operador Ternario**
Crear una **función** `ObtenerEtiquetaEdad` que reciba la edad. Usar el operador ternario (`? :`) dentro de la función para devolver `'Adulto'` o `'Menor'` según si la edad supera los 18 años.

---

### Nivel 4: Diseño Modular Avanzado, Excepciones y Aserciones

**39. Calculadora Modular Robusta (Try-Catch)**
Reescribir el ejercicio de la calculadora modular. Cada operación debe ser una **función** distinta, y la función de división debe usar un bloque **`try-catch`** para manejar la posible `DivideByZeroException`. El programa principal debe informar al usuario si se produce este error de manera controlada.

**40. Validación de Datos (Throw)**
Crear una **función** `CalcularNota` que reciba un valor de tipo entero. Si la nota está fuera del rango de 0 a 10, la función debe lanzar una excepción (`ArgumentOutOfRangeException`) utilizando la sentencia **`throw`**. El programa principal debe capturar la excepción y mostrar un mensaje de error.

**41. Verificación de Precondiciones (Assert)**
Diseñar un **procedimiento** `GenerarDNI` que reciba una cadena con los 8 dígitos numéricos. Antes de continuar, el procedimiento debe usar una **asercíon (`assert`)** para verificar que la cadena tiene exactamente 8 caracteres. Probar con una entrada inválida para ver cómo se lanza la `AssertionException`.

**42. Simulación de Proceso Crítico (Manejo de Múltiples Excepciones)**
Simular una serie de pasos críticos en un proceso (ej. "Conexión a Servidor", "Carga de Datos", "Procesamiento de Datos"). Cada paso debe ser una **función**. La función principal debe llamar a cada una dentro de un bloque **`try`** anidado o secuencial. Implementar diferentes bloques **`catch`** para manejar distintos tipos de excepciones que podrían ocurrir en cada paso (ej. `ConnectionException`, `DataException`, etc.), mostrando mensajes de error específicos. El bloque `finally` debe cerrar la conexión al servidor siempre.

**43. Calculadora Modular con Menú y Bucle Indefinido**
Diseñar una calculadora. Cada operación básica debe ser una **función** distinta. El programa principal debe implementar un menú (usando `repetir-mientras`), y usar un `switch` para llamar a la función correcta, controlando la división por cero.

**44. Juego de Dados Descompuesto (Diseño Modular Estricto)**
Reescribir el juego de dados siguiendo la **descomposición modular** estricta de las fuentes. Implementar los cinco **módulos (procedimientos)**: `Modulo_TURNO`, `Modulo_TIRAR_DADOS`, `Modulo_COMPROBAR_DADOS`, `Modulo_SUMAR_PREMIO` (usando `ref` para los puntos), y `Modulo_ESCRIBIR_RESULTADO`.

**45. Generación de Quiniela con Función de Apuesta**
Crear una **función** `GenerarApuesta` que genere una quiniela completa (15 resultados: 1, X, 2) y la devuelva como una cadena. Luego, usar una **función** `ContarAciertos` para comparar las dos quinielas (usuario y ganadora) resultado por resultado.

**46. Simulación de Tragaperras Modular**
Implementar la simulación de la máquina tragaperras (3 valores aleatorios 0-9). Debe usar: una **función** `GenerarTirada` para cada número, una **función** `CalcularPremio` que determine el premio o la pérdida, y el módulo principal debe gestionar el saldo (empezando en 50€).

**47. Juego de Cara o Cruz Modular**
Crear un **procedimiento** `LanzarMoneda` que utilice `aleatorio()` para simular el lanzamiento. El programa principal debe solicitar la elección del usuario y llamar al módulo para realizar la tirada y determinar e informar si acertó.

**48. Juego de Dados Simple (Par/Impar) Modular**
Diseñar una **función** `TirarDado` que devuelva un número aleatorio entre 1 y 6. El programa principal debe usar esta función para simular un juego en el que el usuario apuesta a Par o Impar y se comprueba la victoria modularmente.

**49. Piedra, Papel, Tijera (Ronda Única)**
Crear una **función** `ObtenerJugadaAleatoria` (que devuelva 1, 2 o 3). Luego, crear una **función** `DeterminarGanador` que reciba la jugada del humano y la de la máquina, y devuelva un código de resultado (ej. 1=Gana Humano, 0=Empate, -1=Gana Máquina).

**50. Piedra, Papel, Tijera (Mejor de Tres)**
Reutilizar las funciones del ejercicio anterior. El programa principal debe gestionar un bucle de **"mejor de tres"** para llevar la cuenta de las victorias del humano y la máquina (contadores simples). El juego termina cuando uno de los jugadores alcance dos victorias.