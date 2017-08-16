from Nodo import NodoDashboard
class Pila:
	"""Pila para cola mensajes"""

	def __init__(self):
		""" Crea una pila vacia """

		self.items= NodoDashboard()
		

	def push(self, x):
		""" Apilar o agregar un elemento x a la pila"""
		#Se agrega al final de la lista
		self.items.append(x)


	def pop(self):
		""" Devolver el elemento x que se ingreso de ultimo"""

		try:
			return self.items.pop()
		except IndexError:
			raise ValueError("La pila está vacía")


	def is_null(self):
		""" Verificar si la pila esta vacia"""
		return self.items == []


