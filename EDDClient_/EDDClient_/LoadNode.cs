using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDClient_
{
    public class Nodo
    {
        public string ip { get; set; }
        public string mascara { get; set; }
    }

    public class Nodos
    {
        public string local { get; set; }
        public string mascara { get; set; }
        public List<Nodo> nodo { get; set; }
    }

    public class RootObject
    {
        public Nodos nodos { get; set; }
    }
}
