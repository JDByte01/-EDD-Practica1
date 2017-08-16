class NodoDashboard:
	"""Nodo de Ips Dashboard"""
	ip = 0
	carnet = 0
	estado = 0
	siguiente = None
	#Constructor Nodo
	def __init__(self, ip, carnet, estado):
		self.ip = ip
		self.carnet = carnet
		self.estado = estado
		self.siguiente = None

	def asignar(self, ip, carnet, estado):
		self.ip = ip
		self.carnet = carnet
		self.estado = estado
		self.siguiente = None
	#Get IP
	def getIp(self):
		return self.ip

	#Get Carnet
	def getCarnet():
		return self.carnet

	#Get Estado
	def getEstado():
		return self.estado

	def getSiguiente():
		return self.siguiente

	def setSiguiente(self, nodo):
		self.siguiente = nodo

class Nodo2:
	def __init__(self):
		print("Hola clase 2")