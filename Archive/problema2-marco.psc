Algoritmo problema2
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
				pnt <- b
				b <- a
				a <- pnt 
			FinSi
			si a < c entonces
				pnt<- a
				a <- c
				c <- pnt
			FinSi
			si b < c entonces
				aux <- b
				b <- c
				c <- pnt
			FinSi
			Escribir a, b, c 
		"B":
			p <- 0
			u <- 1
			vb <- 0
			leer posFib
			Mientras vb = 0
				fib <- p + u
				escribir fib 
				si posFib = fib Entonces
					Escribir posFib, "fibonacci"
					vb <- 1
				SiNo
					si fib > posFib Entonces
						Escribir posFib, " no fibonacci"
						vb <- 1
					SiNo
						p<-u
						u<-fib
					FinSi
				FinSi
			FinMientras
		"C":
			leer n
			cm <- 0
			i <- 1
			res <- 1
			Mientras cm < 3
				si i mod n = 0 entonces 
					res <- res * i
					cm <- cm + 1
				FinSi
				i<-i+1
			FinMientras
			escribir res
		De Otro Modo:
			Escribir "Error"
	FinSegun
FinAlgoritmo