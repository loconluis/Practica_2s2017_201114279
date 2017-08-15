"Web Services"
__author__="loconluis"


from flask import Flask, request

#Nombre de la aplicacion
app = Flask("Estructuras")


#Routing que recibe la app, esta es la de Home y devuelve un Hello World
@app.route('/')
def hello():
    return "Hello World"

# Ruta de acceso a conectado que devuelve un string carnet
@app.route('/conectado')
def hello():
    return "201114279"

# Mas rutas
#Aqui se configura los datos
app.run()

