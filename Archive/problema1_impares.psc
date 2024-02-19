Algoritmo ejecicio1_impares
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
	Escribir b
	Escribir "Nombre : Luz Colque" 
FinAlgoritmo