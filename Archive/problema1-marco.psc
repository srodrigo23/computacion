Algoritmo problema1
	Escribir "Nombre : Marco Flores"
	si numero > 99 & numero < 1000 Entonces
		cop <- numero
		nuevo_num <- 0
		dig <- 0
		Mientras(cop > 0)
			dig <- cop mod 10
			nuevo_num <- (nuevo_num*10) + dig
			cop <- trunc(cop/10)
		FinMientras
		si nuevo_num = numero Entonces
			Escribir numero , " es capicua"
		sino
			Escribir numero , " no es capicua"
		FinSi
	SiNo
		Escribir "no es un numero de 3 cifras"
	FinSi
	
	
FinAlgoritmo