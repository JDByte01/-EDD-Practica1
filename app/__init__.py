from flask import Flask

app = Flask(__name__) 	#Variable app que contiene a Flask
from app import views 	#Paquete [app] carpeta donde esta el archivo __init__.py
						#Se importa views.py