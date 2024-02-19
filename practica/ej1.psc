Algoritmo ejercicio1
	vb <- 0
	Leer num
	Mientras vb=0 Hacer
		num <- num+1
		cd <- 0
		Para i<-1 Hasta num Hacer
			Si num MOD i=0 Entonces
				cd <- cd+1
			FinSi
		FinPara
		Si cd=2 Entonces
			vb <- 1
		FinSi
	FinMientras
	Escribir num
FinAlgoritmo
