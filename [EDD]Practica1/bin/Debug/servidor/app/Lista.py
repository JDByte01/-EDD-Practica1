class Nodo:
	def __init__(self,dato):
		self.siguiente = None
		self.info = dato

	def verNodo(self):
		return self.info

class Lista:
	def __init__(self):
		self.primero = None

	def vacia(self):
		if self.primero == None:
			return True
		else:
			return False

	def insertarPrimero(self, dato):
		temporal = Nodo(dato)
		temporal.siguiente = self.primero
		self.primero = temporal

	def listar(self):
		aux = []
		temporal = self.primero
		while temporal != None:
			aux.append(temporal.verNodo())
			temporal = temporal.siguiente

		return aux

	def borrarPrimero(self):
		if self.vacia() == False:
			self.primero = self.primero.siguiente

	def borrarUltimo(self):
		anterior = self.primero
		actual = self.primero

		while actual.siguiente != None:
			anterior = actual
			actual = actual.siguiente

		anterior.siguiente = None

	def borrarPosicion(self, pos):
		anterior = self.primero
		actual = self.primero
		k = 0
		if pos > 0:
			while k != pos and actual.siguiente != None:
				anterior = actual
				actual = actual. siguiente
				k += 1

			if k == pos:
				anterior.siguiente = actual.siguiente


listas = Lista()
listas.insertarPrimero(1)
listas.insertarPrimero(2)
listas.listar()
listas.borrarPosicion(2)
listas.listar()