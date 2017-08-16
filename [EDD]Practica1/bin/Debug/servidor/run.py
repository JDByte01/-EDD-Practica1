#C:\Users\JOSED\Documents\Visual Studio 2017\Projects\[EDD]Practica1\servidor

	# =================
	# ||Configuracion||
	# =================

from app import app # de la carpeta app importar 
					#la variable app que contiene a Flask

#192.168.43.225
app.run(debug = True, host='0.0.0.0')	#para que jale desde otra pc