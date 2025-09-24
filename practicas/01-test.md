
#### Test: Fundamentos, Programación Estructurada, Modular en DAW

- [Test: Fundamentos, Programación Estructurada, Modular en DAW](#test-fundamentos-programación-estructurada-modular-en-daw)
  - [I. Introducción y Fundamentos (Preguntas 1-8)](#i-introducción-y-fundamentos-preguntas-1-8)
  - [II. Programación Estructurada (Preguntas 9-25)](#ii-programación-estructurada-preguntas-9-25)
  - [III. Programación Modular y Flujo Avanzado (Preguntas 26-45)](#iii-programación-modular-y-flujo-avanzado-preguntas-26-45)
  - [IV. Control de Excepciones y Aserciones (Preguntas 46-50)](#iv-control-de-excepciones-y-aserciones-preguntas-46-50)


##### I. Introducción y Fundamentos (Preguntas 1-8)

1. ¿Cuáles son los primeros paradigmas de programación que se deben aprender y dominar, ya que son la base para otros paradigmas más avanzados? 
A. Programación Orientada a Objetos y Funcional 
B. Programación Estructurada y Modular 
C. Programación Lógica y Declarativa 
D. Programación Concurrente y Distribuida

2. En el lenguaje DAW, ¿dentro de qué bloque principal debe escribirse todo el código, siendo este el punto de entrada de ejecución? 
A. Procedure {} 
B. Function {} 
C. Main {} 
D. Start {}

3. Según la guía del lenguaje DAW, ¿qué tipo de dato se utiliza para almacenar números con decimales de alta precisión? 
A. int 
B. float 
C. decimal 
D. real

4. ¿Cuál es la regla de nomenclatura (convención de estilo) que se debe seguir en DAW para declarar una constante? 
A. camelCase 
B. snake_case 
C. MAYUSCULAS_CON_GUIONES 
D. PascalCase

5. La función de entrada de datos readLine() en el lenguaje DAW siempre devuelve un string. ¿Qué proceso es necesario para utilizar este dato como un número entero (int)? 
A. Conversión Implícita 
B. Casting Explícito (e.g., int.Parse()) 
C. Inferencia de Tipos (var) 
D. Paso por Referencia

6. ¿Cuál es la característica principal de un lenguaje **fuertemente tipado** (o tipado)? 
A. Los tipos de datos se asignan y cambian dinámicamente según la información. 
B. El lenguaje realiza conversiones automáticas sin aviso. 
C. Cada dato debe tener asignado explícitamente el tipo que le corresponde, aportando seguridad. 
D. Permiten que las variables almacenen null por defecto.

7. En la precedencia de operadores, ¿cuál es el operador lógico que tiene la mayor prioridad de evaluación? 
A. && (AND) 
B. || (OR) 
C. ! (NOT) 
D. + (Suma)
8. ¿Cuáles son las tres características esenciales de un algoritmo? 
A. Lógico, rápido y reutilizable. 
B. Imperativo, declarativo y modular. 
C. Preciso, bien definido y finito. 
D. Complejo, extenso y adaptable.

##### II. Programación Estructurada (Preguntas 9-25)

9. Según el Teorema Fundamental de la Programación Estructurada, ¿cuáles son las tres estructuras de control básicas con las que se puede escribir cualquier programa propio? 
A. Secuencial, Iterativa y GOTO 
B. Condicional, Recursiva y Modular 
C. Secuencial, Condicional e Iterativa 
D. Funciones, Procedimientos y Módulos

10. ¿Qué característica define a un "programa propio" además de tener un único punto de entrada y salida? 
A. Debe usar exclusivamente la estructura for. 
B. No deben existir bucles sin fin. 
C. Debe estar escrito en pseudocódigo. 
D. Utiliza variables globales.
11. ¿Qué tipo de estructura condicional permite ejecutar un bloque de código si la condición se cumple y un bloque alternativo si la condición no se cumple? 
A. Alternativa simple (if) 
B. Alternativa doble (if-else) 
C. Alternativa múltiple (switch) 
D. Secuencial

12. En sentencias if anidadas, si no se usan llaves para delimitar bloques, ¿con qué if se asocia la parte else? 
A. Con el primer if de la estructura. 
B. Con el if más lejano posible. 
C. Con el if más cercano posible. 
D. Con el if que contenga la condición booleana más simple.

13. ¿Qué principal ventaja ofrece la estructura switch (o según) frente a una larga cadena de if-else if-else? 
A. Permite evaluar expresiones lógicas complejas. 
B. Ofrece una alternativa más limpia y organizada para comparar una variable contra múltiples valores. 
C. Permite saltar a cualquier parte del código usando GOTO. 
D. Garantiza que el bucle se ejecute al menos una vez.

14. En el contexto de los bucles, ¿qué se debe garantizar siempre para evitar un bucle infinito? 
A. Que exista una variable de control. 
B. Que exista una condición de parada. 
C. Que el bucle sea definido (for). 
D. Que se utilicen solo operadores lógicos.

15. ¿Cuál es la principal diferencia entre los bucles indefinidos while y do-while? 
A. while solo puede usarse con contadores, mientras que do-while usa centinelas. 
B. do-while evalúa la condición después de la primera iteración, garantizando al menos una ejecución. 
C. while evalúa la condición al final, mientras que do-while lo hace al principio. 
D. do-while solo se usa para menús.

16. ¿Cuándo se recomienda usar bucles definidos (for)? 
A. Cuando no se sabe cuántas iteraciones se necesitarán. 
B. Cuando se utiliza una bandera para la condición de salida. 
C. Cuando se conoce de antemano el número exacto de veces que se quiere repetir el código. 
D. Cuando se necesita la estructura de repetición mínima de una vez.

17. En pseudocódigo, ¿qué le sucede a la variable de control (variable) en una estructura para (for)? 
A. Se puede modificar libremente dentro del bucle. 
B. Su valor es siempre 0 al finalizar el bucle. 
C. No se puede modificar dentro del bucle. 
D. Se incrementa de dos en dos por defecto.

18. ¿Cuál de las siguientes es una de las tres formas típicas de controlar la ejecución de un bucle? 
A. Bucles recursivos 
B. Bucles con centinela 
C. Bucles con if-else 
D. Bucles con return

19. ¿Qué son las banderas (flags) en el control de bucles? 
A. Variables que almacenan texto para la salida. 
B. Variables que solo pueden tomar dos valores (normalmente booleanos) para controlar la condición de parada. 
C. Variables que solo se usan en bucles for. 
D. La condición lógica que se evalúa al inicio de un bucle.

20. En un bucle controlado por centinela, ¿qué es el centinela? 
A. El contador del bucle. 
B. Un valor especial introducido por el usuario o detectado por el programa que indica la parada. 
C. Una variable booleana que cambia de true a false. 
D. La variable de acumulación de una suma o producto.

21. ¿Para qué es especialmente útil la técnica de bucles anidados? 
A. Para manejar la recursividad. 
B. Para el manejo de matrices. 
C. Para simplificar el paso por referencia. 
D. Para la validación de entradas con early return.

22. ¿Qué representa la estructura Secuencial? 
A. Un bloque de código que se repite. 
B. La ejecución de las instrucciones una detrás de la otra, en el orden en que están escritas. 
C. La ejecución de un bloque de código u otro dependiendo de una condición. 
D. La división del programa en módulos.

23. ¿Qué es la Iteración (o bucle)? 
A. Un bloque de código que se repite mientras se cumpla una determinada condición. 
B. La ejecución de sentencias una detrás de otra. 
C. La evaluación de una expresión para decidir la siguiente sentencia a ejecutar. 
D. El único punto de entrada de un programa.

24. ¿Por qué el Teorema Fundamental de la Programación Estructurada establece que el uso de la sentencia GOTO es innecesaria? 
A. Porque GOTO complica el uso de bucles. 
B. Porque las estructuras secuencial, condicional e iterativa son suficientes. 
C. Porque GOTO solo funciona en lenguajes no tipados. 
D. Porque solo se permite su uso en procedimientos.

25. ¿Qué se denomina bucle infinito? 
A. La ejecución de la sentencia for. 
B. Un bucle cuya condición de parada nunca se cumple. 
C. El uso de la recursividad sin condición de fin. 
D. El efecto de los bucles anidados.

##### III. Programación Modular y Flujo Avanzado (Preguntas 26-45)

26. La programación modular se basa en la técnica de descomponer un problema grande en subproblemas más simples. ¿Cómo se conoce esta técnica? 
A. Recursividad 
B. Ámbito Global 
C. Divide y Vencerás (DAC) 
D. Paso por Referencia

27. ¿Cuál de las siguientes es una ventaja clave de la Programación Modular? 
A. Aumenta la complejidad del diseño. 
B. Permite que varios programadores trabajen en el mismo proyecto y reduce el tiempo de desarrollo. 
C. Reduce la necesidad de la sentencia return. 
D. Obliga al uso exclusivo de variables globales.

28. ¿Qué es un procedimiento en el contexto de la Programación Modular? 
A. Un bloque de código que siempre devuelve un valor. 
B. Un bloque de código que realiza una tarea específica y no devuelve ningún valor. 
C. Una variable con ámbito global. 
D. El punto de entrada principal del programa.

29. ¿Qué es un parámetro en la definición de una función o procedimiento? 
A. Un valor real que se utiliza en la llamada. 
B. La dirección de memoria de una variable. 
C. Una variable que actúa como "marcador de posición" para los valores que se pasarán. 
D. El resultado que devuelve la función.

30. Cuando se pasa un argumento a un módulo por valor, ¿qué recibe la función? 
A. La dirección de memoria de la variable original. 
B. Una copia del dato original. 
C. Un puntero. 
D. El resultado de la operación.

31. En el lenguaje DAW, ¿qué palabra clave se utiliza para forzar el paso por referencia de un argumento? 
A. out 
B. const 
C. ref 
D. var

32. ¿Cuál es la principal razón de diseño para utilizar el paso por valor (comportamiento por defecto)? 
A. Para modificar directamente la variable original. 
B. Para garantizar seguridad y predictibilidad (inmunidad a efectos secundarios). 
C. Para devolver múltiples valores de una función. 
D. Para ahorrar memoria al copiar grandes estructuras de datos.

33. ¿En qué escenario se recomienda el paso por referencia? 
A. Cuando la función solo necesita devolver un valor único. 
B. Cuando se necesita que un módulo "devuelva" o modifique múltiples valores. 
C. Para trabajar con datos simples como enteros o booleanos. 
D. Cuando el parámetro es una constante.

34. ¿Qué determina el ámbito (o alcance) de una variable? 
A. Si es de tipo entero o real. 
B. La parte del programa donde puede ser accedida o modificada. 
C. Si ha sido declarada con ref o out. 
D. Su nombre y su valor inicial.

35. ¿Cuál es el principal inconveniente de abusar de las variables de **ámbito global**? 
A. Hacen el código más fácil de mantener y depurar. 
B. Complica el código, pudiendo derivar en código "spaghetti". 
C. Se restringe su uso a una sola función. 
D. Requiere el uso de la sentencia return.

36. ¿Qué se conoce como efectos laterales en Programación Modular? 
A. Las variables que se usan en bucles anidados. 
B. La comunicación de datos entre algoritmos al margen de los canales habituales (parámetros y devolución de funciones). 
C. El uso de funciones de librería como Math.sqrt(). 
D. La definición de parámetros por defecto.

37. Si una función se define con el mismo nombre que otra, pero acepta una lista de parámetros diferente (en tipo o número), ¿cómo se llama esta característica? 
A. Encapsulamiento 
B. Herencia 
C. Sobrecarga de funciones 
D. Recursividad

38. ¿Qué palabra clave se usa en DAW para definir un parámetro que puede aceptar un número indeterminado de valores? 
A. ref 
B. params 
C. out 
D. void

39. ¿Cuál es el propósito del mecanismo de Parámetros de Salida (out)? 
A. Devolver un valor usando la sentencia return. 
B. Permitir que una función o procedimiento devuelva múltiples valores. 
C. Establecer el valor por defecto de un parámetro. 
D. Inicializar una variable antes de llamarla.

40. ¿Cuál es la diferencia clave entre ref y out al pasar variables a una función? 
A. Con out, la variable se inicializa automáticamente a cero. 
B. Con ref, la variable debe estar inicializada antes de pasarla; con out, no es necesario, pero debe asignarse dentro de la función. 
C. ref se usa para procedimientos y out para funciones. 
D. No hay diferencia, son sinónimos.

41. ¿Cuál es la principal ventaja de utilizar la técnica de Salida Anticipada (*Early Return*)? 
A. Permite usar variables globales sin riesgo. 
B. Permite evitar anidar estructuras if-else if-else complejas, aplanando la lógica y mejorando la legibilidad. 
C. Garantiza que la función devuelva siempre un valor nulo. 
D. Se aplica solo en estructuras while.

42. La validación de entradas o condiciones fallidas al comienzo de una función que utiliza *Early Return* se conoce como: 
A. Bucle controlado por centinela 
B. Guard Clauses (Cláusulas de Guardia) 
C. Sobrecarga de funciones 
D. Paso por valor

43. ¿En qué contexto se aplica exclusivamente la técnica de *Early Return*? 
A. Solo en el bloque Main {}. 
B. Solo dentro de bucles for y while. 
C. Dentro de funciones y procedimientos. 
D. Exclusivamente en la estructura switch.

44. ¿Qué técnica consiste en que una función o procedimiento se llama a sí mismo de forma repetida? 
A. Sobrecarga 
B. Iteración 
C. Modularidad 
D. Recursividad

45. ¿Qué debe incluir obligatoriamente un problema resuelto recursivamente para evitar un bucle infinito? 
A. Una variable de tipo bool. 
B. Una condición de parada o de fin. 
C. Un parámetro por referencia. 
D. Un bloque Main.

##### IV. Control de Excepciones y Aserciones (Preguntas 46-50)

46. En el lenguaje DAW, la técnica de Control de Excepciones está basada en una clase fundamental de la cual heredan todas las demás. ¿Cuál es esta clase base?
A. SystemError
B. Throwable
C. Exception
D. Error

47. Las excepciones en el lenguaje DAW son catalogadas como no requeridas (*unchecked*). ¿Cuál es la principal implicación de este diseño para el desarrollador?
A. El compilador obliga a manejar todas las excepciones con try-catch.
B. Se debe usar la sentencia `assert` en lugar de `throw`.
C. El código es más limpio, pero la responsabilidad de manejar los errores recae por completo en el desarrollador.
D. Permite que las excepciones se propaguen automáticamente sin detener el programa.

48. ¿Qué bloque dentro de la estructura de manejo de excepciones (`try`, `catch`, `finally`) se ejecuta siempre, sin importar si se lanzó o capturó una excepción?
A. try
B. catch
C. finally
D. throw

49. ¿Cuál es la función principal de la palabra clave `throw` en el manejo de excepciones?
A. Capturar y gestionar una excepción en el bloque `catch`.
B. Verificar que una condición sea verdadera durante la depuración.
C. Lanzar una excepción de forma explícita para definir errores de lógica de negocio.
D. Marcar un bloque de código como potencialmente riesgoso.

50. La aserción (`assert`) es una herramienta que lanza una `AssertionException` si una condición es falsa. ¿Para qué se utiliza principalmente esta herramienta?
A. Para manejar la entrada de datos incorrecta por parte del usuario.
B. Para verificar supuestos sobre el estado interno del programa durante los procesos de depuración y prueba.
C. Para asegurar el cierre de conexiones en el bloque `finally`.
D. Para forzar la conversión de tipos (casting) de manera segura.
