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

@app.route('/conectado')
def validar():
	return "201503836"
	pass

myIP = "192.168.0.13"

@app.route('/setMyIp',methods=['GET'])
def setMyIP(ip):

	try:
		myIP = request.args.get('ip')

		if (ip != ''):
			return 'My IP = ' + ip
			pass
		else:
			return 'No tengo una IP asignada'
		pass
	except Exception as e:
		return 'Error: ' + e
		raise
	pass

#__author__ = "Mac"
#__date__ = "$Ago 6, 2017 11:41:07 AM$"

#from flask import Flask, request

#app = Flask("ejemplo_segundo_semestre_2017")

#@app.route('/metodo2',methods=['POST']) 
#def h():
  #  parametroPython = str(request.form['p'])
   # return "parametro!! = " + parametroPython

#@app.route('/hola') 
#def he():
 #   return "hola Mundo"

#if __name__ == "__main__":
 # app.run(debug=True, host='127.0.0.1')