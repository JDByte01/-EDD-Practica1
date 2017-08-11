from app import app #de la carpeta app importar 
					#la variable app que contiene a Flask
	# ===================
	# ||Todas las rutas||
	# ===================
@app.route('/')
@app.route('/index')
def index():
	return "Estas conectado en el servidor!!"
	pass