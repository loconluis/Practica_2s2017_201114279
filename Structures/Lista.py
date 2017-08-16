# Lista enlazada simple

class NodeL():

    def __init__(self):
        self.ip = None
        self.mask = None
        self.carnet = None
        self.pos = None
        self.sig = None

    def getIP(self):
        return self.ip

    def setIP(self, ip):
        self.ip = ip

    def getMask(self):
        return self.mask

    def setMask(self, mask):
        self.mask = mask

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


class List():

    def __init__(self):
        self.index = None
        self.size = 0

    def isEmptyL(self):
        if self.index is None:
            return True
        else:
            return False

    def addL(self, ip, mask):
        nuevo = NodeL()
        nuevo.setIP(ip)
        nuevo.setMask(mask)
        if self.isEmptyL() is True:
            self.index = nuevo
            self.size = self.size + 1
            nuevo.setPos(self.size)
        else:
            temp = Node()
            temp = self.index
            while temp.getSig() is not None:
                temp = temp.getSig()
            temp.setSig(nuevo)
            self.size = self.size + 1
            nuevo.setPos(self.size)

    def searchL(self, ip, carnet):
        temp = NodeL()
        temp = self.indice
        i = 1
        while temp is not None:
            if temp.getIP == ip:
                temp.setCarnet(carnet)
            else:
                temp = temp.getSig()
            i = i + 1
        return "Dato no encontrado"

    def lengthL(self):
        value = self.size
        return value

    def printList(self):
        if self.isEmptyL() is False:
            aux = NodeL()
            aux = self.index
            while aux is not None:
                print "IP: " + aux.getIP() + " Mask" + aux.getMask()
                aux = aux.getSig()
            else:
                print "No te salio"
