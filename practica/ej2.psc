Algoritmo ejercicio2
	Leer cadena
	i <- 1
	j <- Longitud(cadena)
	cap <- 1
	Mientras i<j Y cap=1 Hacer
		car_i <- Subcadena(cadena,i,i)
		car_j <- Subcadena(cadena,j,j)
		Si car_i<>car_j Entonces
			cap <- 0
		SiNo
			i <- i+1
			j <- j-1
		FinSi
	FinMientras
	Si cap=0 Entonces
		Escribir cadena,' no es capicua'
	SiNo
		Escribir cadena,' es capicua'
	FinSi
FinAlgoritmo
