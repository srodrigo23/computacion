Algoritmo problema2_impares
	Escribir "MENU DE OPCIONES"
	Escribir "================"
	Escribir "A"
	Escribir "B"
	Escribir "C"
	Escribir "Selecciona un inciso:"
	Leer opc
	Segun opc hacer
		"A":
			leer a
			leer b
			leer c
			si a < b Entonces
				aux <- b
				b <- a
				a <- aux
			FinSi
			si a < c entonces
				aux<- a
				a <- c
				c <- aux
			FinSi
			si b < c entonces
				aux <- b
				b <- c
				c <- aux
			FinSi
			Escribir a, b, c 
			
		"B":
			p <- 0
			u <- 1
			vb <- 0
			leer f
			si f >= 0 & f<= 10 Entonces
				Mientras vb = 0
					fib <- p + u
					si f = fib Entonces
						Escribir posFib, "fibonacci"
						vb <- 1
					SiNo
						si fib > f Entonces
							Escribir f, " no fibonacci"
							vb <- 1
						SiNo
							p<-u
							u<-fib
						FinSi
					FinSi
				FinMientras
			SiNo
				escribir "fuera de rango"
			FinSi
			
		"C":
			leer n
			cm <- 0
			i <- 1
			res <- 0
			Mientras cm < 5
				si i mod n = 0 entonces 
					res <- res + i
					cm <- cm + 1
				FinSi
				i<-i+1
			FinMientras
			escribir res
		De Otro Modo:
			Escribir "error de inciso"
	FinSegun
FinAlgoritmo