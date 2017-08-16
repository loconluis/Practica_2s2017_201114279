class NodeP(self):
    
    def __init__(self):
        self.dato = None
        self.sig = None

    def getDato(self):
        return self.dato

    def setDato(self, dato):
        self.dato = dato

    def getSig(self):
        return self.sig

    def setSig(self, sig):
        self.sig = sig

class Stack():

    def __init__(self):
        self.head = None
        self.tail = None
        self.size = 0

    def isEmptyP(self):
        if self.head is None:
            return True
        else:
            return False

    def push(self, dato):
        nuevo = NodeP()
        nuevo.setDato(dato)
        if self.isEmptyP() is True:
            self.head = nuevo
            self.tail = self.head
            self.size = self.size + 1
        else:
            temp = NodeP()
            temp = self.head
            while temp.getSig() is not None:
                temp = temp.getSig()
            temp.setSig(nuevo)
            self.tail = nuevo
            self.size = self.size + 1

    def pop(self):
        if self.tail is not None:
            temp1 = NodeP()
            temp1 = NodoP()
            temp2 = NodoP()
            temp1 = self.cola
            temp2 = self.cabeza
            if temp2 == temp1:
                print "Estoy aqui"
                temp2 = None
                self.cola = temp2
                return temp1.getDato()
                temp1 = None
                self.size = self.size - 1
            else:
                print "estoy aqui :3"
                while temp2.getSig() is not temp1:
                    temp2 = temp2.getSig()
                temp2.setSig(None)
                self.cola = temp2
                return temp1.getDato()
                temp1 = None
                self.size = self.size - 1
        else:
            return "Lista Vacia"

    def verPila(self):
        """Imprime la pila."""
        if self.isEmptyP() is False:
            actual = NodoP()
            actual = self.cabeza
            while actual is not None:
                print actual.getDato()
                actual = actual.getSig()
        else:
            print "No te salio"

    def lengthP(self):
        value = self.size
        return value