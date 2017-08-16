from app import app#de la carpeta app importar 
from flask import request
from flask import render_template
								#la variable app que contiene a Flask
	# ===================
	# ||Todas las rutas||
	# ===================

	# pass (le dice a Python que no tiene que hacer nada)
url = "http://127.0.0.1:5000/mensajeGet"

@app.route('/')
@app.route('/index')
def index():
	return "Estas conectado en el servidor!!"

@app.route('/cargarNodos')
def cargarNodos():
	values = request.get_json()

	return values['nodos']['local']
	#return "192.168.0.1"
	
	#Mostrar la tabla del dashboard
@app.route('/dashboard')
def dashboard():
	return render_template('tablaDashboard.html')
	#=======================================

@app.route('/index2')
def hello():
	data = {"api":"rest hola"}
	return json.dumps(data)

@app.route('/mensajeJSON',methods=['POST'])
def leerJSON():

	values = request.get_json()

	ip = values['ip']
	mensaje = values['mensaje']

	valor = "IP = " + ip + ", Mensaje = " + mensaje

	#print(valor)
	return "true"

	#=======================================
	#	Probando Metodos
	#=======================================
from Nodos import NodoDashboard
from ListaSimple import ListaSimple
#temp = NodoDashboard()
@app.route('/nodoDashboard/<ip>/<carnet>/<estado>')
def asignarNodo(ip, carnet, estado):
	temp.asignar(ip,carnet,estado)

	return "asignacion correcta"

@app.route('/nodo')
def mostrarNodo():
	return temp.getIp()

Lista = ListaSimple()
@app.route('/lista/<ip>/<carnet>/<estado>')
def insertarLista(ip,carnet, estado = "inactivo"):
	Lista.agregarFinal(ip, carnet, estado)
	return "Se agrego {} - {} - {}".format(ip, carnet, estado)

@app.route('/lista/tamanio')
def listaTamanio():
	return Lista.getTamanio()

@app.route('/lista/mostrar')
def mostrarLista():
	
	temp = Lista.getLista()

	for x in temp:
		print(x)

	return temp

#from Pila import Pila
#pilaMensaje = Pila()
#@app.route('/mensaje')
	#=======================================

#Yo respondo
@app.route('/conectado')
def validar():
	return "201503836"

#Yo recibo mensaje
@app.route('/mensaje')
def mensaje():
	#m = str(request.form['inorden'])
	mensaje = str(request.args.get('inorden'))
	#print(mensaje)
	return "El mensaje es {}".format(mensaje)


#@app.route('/consultarNodo')
#def consultar():
#	r = requests.get('http://127.0.0.1:5000/conectado')
#	r.text
#	return r.text

#myIP = "192.168.0.13"

@app.route('/setMyIp',methods=['GET'])
def setMyIP(ip):

	try:
		myIP = request.args.get('ip')

		if (ip != ''):
			return 'My IP = ' + ip
		else:
			return 'No tengo una IP asignada'
	except Exception as e:
		return 'Error: ' + e
		raise
	pass

#@app.route('/mensaje', methods=['GET'])
#def mensaje():
#	mensajeInorden = str(request.form['inorden'])
#	if mensajeInorden != "" or mensajeInorden != None:
#		return "true"
#	else:
#		return "false"


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