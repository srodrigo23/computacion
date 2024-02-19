Algoritmo problema2
	Escribir "MENU DE OPCIONES"
	Escribir "-----------------"
	Escribir "A. primer inciso  "
	Escribir "B. segundo inciso  "
	Escribir "C. tercero inciso  "
	Escribir "Selecciona una opcion :"
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
			leer posFib
			vb <- 0
			Mientras vb = 0
				fib <- p + u
				escribir fib 
				si posFib = fib Entonces
					Escribir posFib, " es fibonacci"
					vb <- 1
				SiNo
					si fib > posFib Entonces
						Escribir posFib, " no es fibonacci"
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
			escribir n , " -> ", res
		De Otro Modo:
			Escribir "Error de opciones"
	FinSegun
	
	
FinAlgoritmo