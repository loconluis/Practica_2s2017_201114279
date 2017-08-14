"Web Services"
__author__="loconluis"


from flask import Flask, request

#Nombre de la aplicacion
app = Flask("Estructuras")


#Routing que recibe la app, esta es la de Home y devuelve un Hello World
@app.route('/')
def hello():
    return "Hello World"


#Aqui se configura los datos
app.run()

