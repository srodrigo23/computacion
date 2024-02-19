Algoritmo problema1
		
	Leer numero
	si numero > 99 & numero < 1000 Entonces
		aux <- numero
		nn <- 0
		d <- 0
		Mientras(aux > 0)
			d <- aux mod 10
			nn <- (nn*10) + d
			aux <- trunc(aux/10)
		FinMientras
		si nn = numero Entonces
			Escribir numero , " es capicua"
		sino
			Escribir numero , " no es capicua"
		FinSi
	SiNo
		Escribir "error"
	FinSi
	
	Escribir "Nombre : Russland Gomez"
FinAlgoritmo