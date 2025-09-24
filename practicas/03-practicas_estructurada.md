### 40 Ejercicios de Programación Estructurada (Lenguaje DAW)

- [40 Ejercicios de Programación Estructurada (Lenguaje DAW)](#40-ejercicios-de-programación-estructurada-lenguaje-daw)
- [Nivel 1: Secuencias y Condicionales Simples (Problemas 1-10)](#nivel-1-secuencias-y-condicionales-simples-problemas-1-10)
- [Nivel 2: Condicional Múltiple, Bucles Definidos y Anidados (Problemas 11-19)](#nivel-2-condicional-múltiple-bucles-definidos-y-anidados-problemas-11-19)
- [Nivel 3: Bucles Indefinidos, Centinelas y Banderas (Problemas 20-30)](#nivel-3-bucles-indefinidos-centinelas-y-banderas-problemas-20-30)
- [Nivel 4: Algoritmos Avanzados, Simulación y Control de Errores (Problemas 31-40)](#nivel-4-algoritmos-avanzados-simulación-y-control-de-errores-problemas-31-40)
- [Nivel 5: Control de Excepciones y Aserciones (Problemas 37-40)](#nivel-5-control-de-excepciones-y-aserciones-problemas-37-40)


### Nivel 1: Secuencias y Condicionales Simples (Problemas 1-10)

**1. Cálculo de Área de Cuadrado**
Calcular y mostrar la superficie y el perímetro de un cuadrado cuyo lado se pide por teclado.

**2. Cálculo de Área de Rectángulo**
Calcular y mostrar la superficie y el perímetro de un rectángulo cuyos datos (largo y ancho) se piden por teclado.

**3. Cálculo de Círculo**
Calcular y mostrar el área y la circunferencia de un círculo, dado el radio introducido por el usuario.

**4. Media de Tres Números**
Diseñar un algoritmo que calcule la media de tres números que se piden al usuario. El resultado se debe mostrar con decimales.

**5. Cálculo de Impuestos**
Leer el salario anual de una persona y calcular el impuesto a pagar, sabiendo que si el salario es superior a 30.000 €, se aplica un impuesto del 15%; en caso contrario, se aplica un 10%.

**6. Determinación de Signo**
Leer un número por teclado y determinar si es positivo, negativo o cero.

**7. Validación de Raíz Cuadrada**
Calcular la raíz cuadrada de un número introducido por teclado. Si el número es negativo, se debe informar al usuario de que la operación no es posible.

**8. Resta del Mayor**
Leer dos números por teclado, A y B, y calcular la resta del mayor menos el menor, mostrando el resultado.

**9. Conversión de Temperatura**
Realizar un conversor que pida la temperatura en Centígrados y la convierta a Farenheit, o viceversa, permitiendo al usuario elegir el sentido de la conversión.

**10. Verificación de Orden**
Diseñar un algoritmo que determine si tres números (X, Y, Z) pedidos por teclado están ordenados de menor a mayor.

---

### Nivel 2: Condicional Múltiple, Bucles Definidos y Anidados (Problemas 11-19)

**11. Determinar Bisiesto**
Determinar si un año proporcionado por teclado es bisiesto o no, utilizando condicionales compuestos.

**12. Mayor, Menor y Mediano**
Dados tres números enteros pedidos por teclado, determinar y mostrar cuál es el mayor, cuál el menor y cuál el mediano, utilizando solo condicionales anidados.

**13. Precio de Billete de Tren**
Calcular el precio final de un billete de tren (precio por km: 2,5 €), aplicando una reducción del 30% si la estancia es superior a 7 días *y* la distancia superior a 800 km.

**14. Jornal Diario de Empleado**
Calcular el jornal diario de un empleado considerando turnos (diurno/nocturno) y recargos especiales si es domingo, utilizando la estructura **según** (switch).

**15. Cálculo de Factorial**
Calcular el factorial de un número entero (N!) utilizando un bucle definido (**para**).

**16. Cálculo de Potencia**
Dados dos números enteros, A y B, calcular la potencia A elevado a B ($A^B$) utilizando un bucle definido (**para**).

**17. Impresión de Pares en Rango**
Escribir todos los números pares que se encuentran entre un número inicial (A) y un número final (B) proporcionados por el usuario.

**18. Suma de Impares en Rango**
Sumar todos los números impares que existen entre dos números cualquiera (A y B) pedidos por teclado.

**19. Generación de Tablas Anidadas**
Generar y mostrar las tablas de multiplicar completas del 1 al 10. Se debe utilizar la estructura **para** anidada (un bucle dentro de otro).

---

### Nivel 3: Bucles Indefinidos, Centinelas y Banderas (Problemas 20-30)

**20. Algoritmo de Restas Sucesivas**
Dados dos números enteros, calcular el cociente y el resto de su división mediante la técnica de restas sucesivas (utilizando un bucle **mientras**).

**21. Conteo de Cifras**
Determinar el número de cifras de un número entero (positivo o negativo) introducido por teclado, utilizando un bucle que divida el número sucesivamente.

**22. Días del Mes**
Dado el número de un mes y el año, deducir y mostrar el número de días que tiene ese mes, utilizando la estructura **según** y comprobando si el año es bisiesto.

**23. Resolución de Ecuación de Segundo Grado**
Pedir los tres coeficientes (a, b, c) y mostrar las posibles soluciones, determinando si tiene dos, una, o ninguna solución real, basándose en el valor del discriminante.

**24. Actualización de Reloj**
Dada una hora (H:M:S) por teclado, realizar el algoritmo que muestre la hora después de incrementarle un segundo, gestionando el acarreo de minutos, horas y el ciclo de 24 horas.

**25. Comprobación de Número Primo**
Determinar si un número entero introducido por teclado es primo, utilizando un bucle controlado por un indicador (**bandera o flag**).

**26. Listado de Números Primos en Rango**
Reutilizar la lógica de la comprobación de número primo para mostrar todos los números primos que hay entre 1 y 1000.

**27. Media de Cantidad Indefinida (Centinela)**
Calcular la media de una cantidad indefinida de números. El programa parará cuando se introduzca un número negativo (el centinela), y al final debe mostrar la media de los números válidos introducidos.

**28. Conteo de Aprobados y Suspensos**
Introducir las notas de N alumnos hasta que se ingrese una nota negativa (centinela). Indicar al final cuántos aprobados y cuántos suspensos hay.

**29. Mayor de una Serie Indefinida**
Diseñar un algoritmo que determine el mayor valor de una serie de números enteros introducidos por teclado. La serie finaliza cuando se introduce el número 0.

**30. Verificación de Dígitos Pares (Control por Bandera)**
Leer un número entero positivo. Determinar si el número contiene al menos un dígito que sea par. El programa debe recorrer el número dígito a dígito y utilizar una **bandera** (flag lógico).

---

### Nivel 4: Algoritmos Avanzados, Simulación y Control de Errores (Problemas 31-40)

**31. Simulación de Devolución de Monedas**
Simular el mecanismo de devolución de monedas de una máquina expendedora. El programa pregunta una cantidad de dinero en euros (ej. 3,47 €) y calcula la cantidad mínima de monedas necesarias para devolverla (ej. 1 de 2€, 1 de 1€, 2 de 20cts, etc.).

**32. Conversión Binario a Decimal**
Dado un número binario (cadena de 0s y 1s), calcular y mostrar su equivalente en número decimal, utilizando la lógica de potencias de 2 y un bucle de repetición.

**33. Conversión Decimal a Binario**
Dado un número entero en decimal, calcular y mostrar su equivalente binario, utilizando la lógica de divisiones sucesivas por 2 y un bucle.

**34. Juego del Número Secreto**
El ordenador "piensa" un número al azar del 1 al 100. El usuario intenta adivinarlo. El programa debe dar pistas ("mayor" o "menor"). Al final, se pregunta al usuario si quiere jugar de nuevo (bucle exterior).

**35. Simulación de Máquina Tragaperras (Estructurada)**
Implementar una simulación básica de una máquina tragaperras (tres valores aleatorios entre 0 y 9). Gestionar el saldo, las pérdidas y las ganancias. El juego termina si el saldo llega a 0 o si el usuario decide no continuar.

**36. Coste de Llamada Telefónica**
Calcular el coste final de una llamada telefónica dado el tiempo de duración en minutos y la hora de inicio (entero de 0 a 23), aplicando las tarifas y recargos según el turno nocturno.

---

### Nivel 5: Control de Excepciones y Aserciones (Problemas 37-40)

**37. Control de División por Cero (Try-Catch)**
Diseñar un algoritmo que pida dos números (dividendo y divisor). Implementar la división dentro de un bloque **`try`**. Usar un bloque **`catch`** específico para capturar la posible `DivideByZeroException` y mostrar un mensaje de error controlado al usuario, sin que el programa termine abruptamente.

**38. Validación de Lógica de Negocio (Throw)**
Crear un algoritmo que pida un porcentaje de descuento. Si el porcentaje introducido es negativo o excede el 100%, el programa debe lanzar una excepción explícita utilizando la sentencia **`throw`**. El programa debe capturar esta excepción y notificar al usuario.

**39. Garantía de Limpieza (Finally)**
Simular un proceso que requiere recursos críticos (ej. "Apertura de Conexión a Base de Datos"). Coloque la operación potencialmente fallida dentro de **`try`**. Asegúrese de que el mensaje de "Recurso Liberado / Conexión Cerrada" se ejecute **siempre** en el bloque **`finally`**, sin importar si la operación en `try` tuvo éxito o falló.

**40. Verificación de Precondición (Assert)**
Diseñe un segmento de código para el cálculo de un área (lado $L$). Utilice una **asercíon (`assert`)** al inicio del segmento para verificar que el valor de $L$ sea mayor que cero. Pruebe el código con un valor negativo y observe cómo se lanza la `AssertionException` en fase de depuración.