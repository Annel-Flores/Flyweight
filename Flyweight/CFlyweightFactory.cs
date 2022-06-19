using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class CFlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string pNombre)
        {
            //Verificamos si ya existe

            bool existe = false;
            foreach ( IFlyweight f in flyweights)
            {
                if (f.ObtenNombre() == pNombre)
                    existe = true;
            }
            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha adicionado");
                return -1;
            }
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(pNombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count;
                return conteo - 1;
            }
        }
        public IFlyweight this[int index]
        {
          get { return flyweights[index]; }
        }
    }
}
