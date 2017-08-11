from webService import webService
@webService.route('/')
def home(): #Metodo home
	return 'Estas en el servidor Python!!!'
	pass

##########################################################################
if __name__ == '__main__':
	webService.run(debug = True) #Hace debug automaticamente
	pass