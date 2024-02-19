Algoritmo ejercicio4
	Escribir 'Ingrese un anio :'
	Leer anio
	Si anio MOD 4=0 Entonces
		Si anio MOD 100=0 Entonces
			Si anio MOD 400=0 Entonces
				Escribir anio,' es bisiesto'
			SiNo
				Escribir anio,' no es bisiesto'
			FinSi
		SiNo
			Escribir anio,' es bisiesto'
		FinSi
	SiNo
		Escribir anio,' no es bisiesto'
	FinSi
FinAlgoritmo
