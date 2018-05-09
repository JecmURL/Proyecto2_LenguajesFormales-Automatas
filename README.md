# Proyecto2_LenguajesFormales-Automatas
Proyecto Máquinas de Turing Lenguajes formales

El siguiente proyecto consiste en un WFA, la cual contienen 5 máquinas de Turing simuladas que realizan distintas actividades.

La aplicación consiste en una interfaz simple donde por medio de un selector de opciones se escoge la actividad a ejecutar, un texto de entrada e iniciar.

Las máquinas de Turing al ser maquinas secuenciales y de pasos a cualquier input que no pertenesca al alfabeto o gramática de la MT, será rechazado.

# Maquinas de Turing con operaciones Aritmeticas

1. Suma en código unario

Usa el alfabeto {1,+} se puede realizar la suma de distintas combinaciones siempre y cuando esten separadas por el signo "+" y sea viable realizar la operación entre las mismas. 

2. Resta en código unario

Usa el alfabeto {1,+} se necesitan 2 cadenas de "unos" pero separadas por el signo "-". Se procede convirtiendo el signo "-" en 0 para poder trabajar de forma mas eficaz, la MT esta diseñada para que pueda identificar si es una operacion cuyo resultado sera positivo o negativo siguiendo esta logica: M-N donde M > N se opera; M-N donde M <= N dara como resultado 0.

3. Multiplicación en código unario

Usa el alfabeto {1,\*} con dos cadenas de "unos" separadas por el signo "\*". Se toma la primer cadena como el "contador" y la segunda cadena como los caracteres a repetir, dando por resultado el valor final de la multiplicacion, ej. 11*111= 111111.

-> En la suma y multiplicacion para poder dar un resultado mas facil de leer se recorre la cadena hasta el final, agregando un símbolo "=" en el mismo, para poder separar el resultado. Para la resta el resultado son la cantidad de unos que deja la MT.

# Maquinas de Turing para cadenas

4. Reconocedora de palíndromos

Ésta máquina usa el alfabeto {a,b,c} y determina si éstas entradas son palíndromas o no. Para hacerlo, va comparando la primera y última letra de la misma, si la letra es igual, elimina las mismas para continuar con el proceso. Este proceso funciona para palindromos pares como impares.


5. Reconoce patrones y los copia

Ésta máquina toma el alfabeto {a,b,c} y realiza una copia idéntica de las mismas. 

Funciona recorriendo cada una de las letras (empezando siempre por la segunda) reemplazando las mismas con un caracter X y haciéndole un espacio al final con un caracter Y.
