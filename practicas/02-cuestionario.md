
#### Cuestionario de Investigación y Desarrollo: Fundamentos, Programación Estructurada, Modular en DAW

- [Cuestionario de Investigación y Desarrollo: Fundamentos, Programación Estructurada, Modular en DAW](#cuestionario-de-investigación-y-desarrollo-fundamentos-programación-estructurada-modular-en-daw)
  - [I. Fundamentos y Estructura del Programa (Preguntas 1-4)](#i-fundamentos-y-estructura-del-programa-preguntas-1-4)
  - [II. Programación Estructurada y Flujo de Control (Preguntas 5-11)](#ii-programación-estructurada-y-flujo-de-control-preguntas-5-11)
  - [III. Modularidad y Diseño de Funciones (Preguntas 12-18)](#iii-modularidad-y-diseño-de-funciones-preguntas-12-18)
  - [IV. Control de Excepciones y Aserciones (Preguntas 19-20)](#iv-control-de-excepciones-y-aserciones-preguntas-19-20)


##### I. Fundamentos y Estructura del Programa (Preguntas 1-4)

1. Justifique la afirmación de que los paradigmas de Programación Estructurada y Modular son la **base fundamental** para la comprensión de paradigmas avanzados como la Programación Orientada a Objetos o Funcional.

2. Describa y analice los tres elementos clave que, según la Programación Estructurada, permiten al programador mantener el programa "dentro de la cabeza".

3. El Teorema Fundamental de la Programación Estructurada define un "programa propio". ¿Qué implicaciones tiene la restricción de que **no deben existir bucles sin fin** para la verificación y seguridad del programa?.

4. La función de entrada `readLine()` en el lenguaje DAW siempre devuelve un string. Explique la necesidad del *casting* explícito (`int.Parse`) en el desarrollo de programas que manejan entrada numérica y discuta los riesgos de la pérdida de información asociados a las conversiones de tipos.

##### II. Programación Estructurada y Flujo de Control (Preguntas 5-11)

5. Compare la estructura `if-else if-else` con la estructura `switch` (o según). ¿En qué condiciones de legibilidad y diseño es preferible la implementación del `switch` para manejar la selección múltiple?.

6. En el contexto de estructuras condicionales anidadas (`if` anidados), ¿cómo resuelve el lenguaje la ambigüedad al asociar una parte `else`? Cite la regla que rige esta asociación.

7. Justifique la decisión de diseño de incluir el bucle `do-while` en los lenguajes de programación. ¿En qué tipo de interacciones con el usuario (ej. menús o preguntas de validación) el `do-while` es la elección estructural más adecuada frente al `while`?.

8. Analice por qué la variable de control de un bucle `para` (for) **no se puede modificar** dentro del cuerpo del bucle. ¿De qué manera esta restricción garantiza la predictibilidad y se adhiere a los principios de la Programación Estructurada?.

9. Explique la diferencia conceptual y práctica entre un **Bucle controlado por Indicadores (Banderas)** y un **Bucle controlado por Centinela**. Proporcione un escenario donde una bandera booleana (`bool`) es indispensable para controlar el flujo de un bucle.

10. ¿Por qué se afirma que la utilización de la sentencia `GOTO` es totalmente innecesaria en la Programación Estructurada?. ¿Qué efecto tiene la sentencia `GOTO` en la legibilidad comparado con las tres estructuras básicas?.

11. Los **bucles anidados** son una técnica iterativa avanzada. Justifique por qué esta técnica es especialmente útil y necesaria para la manipulación de estructuras de datos bidimensionales como las matrices.

##### III. Modularidad y Diseño de Funciones (Preguntas 12-18)

12. Defina el principio de **"Divide y Vencerás" (DAC)**. ¿Cómo se traduce este principio en la práctica de la Programación Modular para facilitar la resolución de problemas grandes y la colaboración entre programadores?.

13. ¿Cuál es la diferencia definitoria entre una **Función** y un **Procedimiento** en términos de su salida?. ¿Cómo afecta esta diferencia al diseño de la firma del módulo y a su invocación desde el Main?.

14. Analice la distinción entre el **paso por valor** y el **paso por referencia**. Desde una perspectiva de seguridad y predictibilidad del código, ¿por qué el paso por valor (la opción por defecto) garantiza la "inmunidad a efectos secundarios"?.

15. Los **efectos laterales** son un concepto crucial en la modularidad. Defina qué son y por qué el uso de variables de **ámbito global** se considera una práctica que debe ser evitada para prevenir el "código spaghetti".

16. Explique la diferencia esencial entre el parámetro de paso por referencia (`ref`) y el parámetro de salida (`out`). ¿Por qué el uso de `out` en la declaración de un parámetro permite **no inicializar** la variable antes de la llamada, a diferencia de `ref`?.

17. Analice el propósito del **Early Return**. ¿Cómo la aplicación de **Cláusulas de Guardia** (*Guard Clauses*) al inicio de una función logra el objetivo de **aplanar la lógica** y evitar el "efecto cascada" en las estructuras condicionales?.

18. La **Sobrecarga de funciones** permite múltiples módulos con el mismo nombre. Justifique su uso moderado, considerando que el uso de parámetros por defecto, opcionales o nombrados puede lograr resultados similares.

##### IV. Control de Excepciones y Aserciones (Preguntas 19-20)

19. El control de excepciones es crucial para la robustez en el **despliegue de aplicaciones web**. Explique qué es una excepción y justifique la decisión de diseño de que las excepciones en DAW sean **no requeridas** (*unchecked*), indicando la clase base de la que heredan todas las excepciones.

20. Describa la diferencia de propósito entre la sentencia `throw` y la aserción (`assert`). ¿En qué contexto se recomienda usar `assert` (y qué tipo de excepción lanza) frente a usar `throw` para validar errores de lógica de negocio?.
