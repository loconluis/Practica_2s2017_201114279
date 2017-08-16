# Lista enlazada simple

class NodeLD():

    def __init__(self):
        self.ip = None
        self.mensaje = None
        self.carnet = None
        self.pos = None
        self.sig = None
        self.ant = None

    def getIP(self):
        return self.ip

    def setIP(self, ip):
        self.ip = ip

    def getMensaje(self):
        return self.mensaje

    def setMensaje(self, mensaje):
        self.mensaje = mensaje

    def getCarnet(self):
        return self.carnet

    def setCarnet(self, carnet):
        self.carnet = carnet

    def getPos(self):
        return self.pos

    def setPos(self, pos):
        self.pos = pos

    def getSig(self):
        return self.sig

    def setSig(self, sig):
        self.sig = sig
    
    def getAnt(self):
        return self.ant

    def setAnt(self, ant):
        self.ant = ant

class DoubleList():

    def __init__(self):
        self.head = None
        self.tail = None
        self.size = 0

    def isEmptyDL(self):
        if self.head is None:
            return True
        else:
            return False

    def addFirstDL(self, carnet, ip, mensaje):
        nuevo = NodeLD()
        nuevo.setCarnet(carnet)
        nuevo.setIP(ip)
        if self.isEmptyDL() is True:
            self.head = self.tail = nuevo
            self.size = self.size + 1
            nuevo.setPos(self.size)
        else:
            nuevo.setSig(self.head)
            self.head.setAnt(nuevo)
            self.size = self.size + 1
            nuevo.setPos(self.size)
            self.head = nuevo
    
    # def addLastDL(self, carnet, ip, mensaje):

    def searchDL(self, carnet):
        temp = self.head
        while temp is not None:
            if temp.getCarnet() == carnet:
                return temp
            else:
                temp = temp.getSig()
        return "No existe"

