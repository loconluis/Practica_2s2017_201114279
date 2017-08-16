#Cola
class NodeQ():

    def __init__(self):
        self.dato = None
        self.sig = None
    
    def getDato(self):
        return self.dato

    def setDato(self, dato):
        self.dato = dato

    def getSig(self):
        return self.sig

    def setSig(self, siguiente):
        self.sig=siguiente

class Queue():

    def __init__(self):
        self.cabeza = None
        self.cola = None
        self.size = 0

    def isEmptyQ(self):
        if self.cabeza is None:
            return True
        else:
            return False

    def queue(self, dato):
        nuevo = NodeQ()
        nuevo.setDato(dato)
        if self.isEmptyQ() is True:
            self.cabeza= nuevo
            self.cola=self.cabeza
        else:
            temp = NodeQ()
            temp = self.cabeza
            while temp.getSig() is not None:
                temp = temp.getSig()
            temp.setSig(nuevo)
            self.cola=nuevo

    def dequeue(self):
        if self.cabeza is not None:
            temp = NodeQ()
            temp = self.cabeza
            self.cabeza = temp.getSig()
            return temp.getDato()
            temp = None
        else:
            return "Empty List"

    def lengthQ(self):
        """Metodo devuelve la longitud de la Cola."""
        value = self.size
        return value

    def printQueue(self):
        """Imprime la cola."""
        if self.estaVacia() is False:
            aux = NodeQ()
            aux = self.cabeza
            while aux is not None:
                print aux.getDato()
                aux = aux.getSig()
        else:
            print "No te salio"