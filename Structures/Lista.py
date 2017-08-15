# Lista enlazada simple

class Node():

    def __init__(self):
        self.ip = None
        self.mask = None
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

    def isEmpty(self):
        if self.index is None:
            return True
        else:
            return False

    def add(self, ip, mask):
        nuevo = Node()
        nuevo.setIP(ip)
        nuevo.setMask(mask)
        if self.isEmpty() is True:
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

    def search(self, pos):
        temp = Node()
        temp = self.indice
        i = 1
        while temp is not None:
            if temp.getPos() == pos:
                return str(i)
            else:
                temp = temp.getSig()
            i = i + 1
        return "Dato no encontrado"

    def length(self):
        value = self.size
        return value

    def printList(self):
        if self.isEmpty() is False:
            aux = Node()
            aux = self.index
            while aux is not None:
                print "IP: " + aux.getIP() + " Mask" + aux.getMask()
                aux = aux.getSig()
            else:
                print "No te salio"
