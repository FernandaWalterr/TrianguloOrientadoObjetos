namespace TrianguloOrientadoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de Z: ");
            double z = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo();
            triangulo.DefinirLados(x, y, z);

            if (triangulo.EhTriangulo())
            {
                if (triangulo.EhEquilatero())
                {
                    Console.WriteLine("É um triângulo equilátero!");
                }
                else if (triangulo.EhIsosceles())
                {
                    Console.WriteLine("É um triângulo isósceles!");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno!");
                }
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo com esses valores!");
            }
        }
    }
}