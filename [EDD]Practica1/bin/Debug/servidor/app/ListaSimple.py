from Nodos import NodoDashboard
class ListaSimple:
	"""Lista Simple Dashboard"""
		#inicio = ""
		#tamanio = 0

	def __init__(self,):
		self.inicio = None
		self.tamanio = 0

	def esVacia(self):
		return self.inicio == None

	def getTamanio():
		return self.tamanio

	def agragarFinal(self, ip, carnet, estado):

		nuevo = NodoDashboard(ip, carnet, estado)

		if esVacia():
			self.inicio = nuevo
		else:
			self.aux = self.inicio

			i = 0
			while self.aux.getSiguiente() != None:
				self.aux = self.aux.getSiguiente()

			self.aux.setSiguiente(nuevo)

		self.tamanio = self.tamanio + 1

	def agregarInicio(self, ip, carnet, estado):

		nuevo = NodoDashboard(ip, carnet, estado)

		if self.esVaia():
			self.inicio = nuevo

		else:
			nuevo.setSiguiente(self.inicio)
			self.inicio = nuevo

		self.tamanio = self.tamanio + 1

	def getInicio():
		return self.inicio

	def getLista():
		temp = []
		if esVacia():
			aux = self.inicio
			i = 0

			while aux != None:
				temp.append(aux.getIp)
				temp.append(aux.getCarnet)
				temp.append(aux.getEstado)

				aux = aux.getSiguiente()

		return temp


		