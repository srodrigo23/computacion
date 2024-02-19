Algoritmo problema1
	Escribir "Mi nombre es : Silvia Cruz"
	vb <- 0
	Mientras (vb = 0)
		Leer numero
		si numero > 99 & numero < 1000 Entonces
			//tres cifras
			vb <- 1
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
		FinSi
	FinMientras
FinAlgoritmo