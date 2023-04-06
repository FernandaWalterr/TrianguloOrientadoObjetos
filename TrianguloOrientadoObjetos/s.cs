using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOrientadoObjetos
{
    class Triangulo
    {
        private double x, y, z;

        public void DefinirLados(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool EhTriangulo()
        {
            return (x + y > z && x + z > y && y + z > x);
        }

        public bool EhEquilatero()
        {
            return (x == y && x == z);
        }

        public bool EhIsosceles()
        {
            return (x == y || x == z || y == z);
        }
    }
}