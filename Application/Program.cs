using System;
using NombreComplexe;

namespace NombreComplexe
{
    public class Application
    {
        public static void Main(string[] args)
        {
             NombreComplexe a = new NombreComplexe(1, 1);
            NombreComplexe b = new NombreComplexe(1, -1);
            NombreComplexe c = a.Conjuguer();
            NombreComplexe d = b.Conjuguer();

            Console.WriteLine($"Notation Algébrique: {a} et notation trigonométrique: { a.NotationTrigonométrique()}");
            Console.WriteLine($"Notation Algébrique: {b} et notation trigonométrique: { b.NotationTrigonométrique()}");
            Console.WriteLine($"Notation Algébrique: {c} et notation trigonométrique: { c.NotationTrigonométrique()}");
            Console.WriteLine($"Notation Algébrique: {d} et notation trigonométrique: { d.NotationTrigonométrique()}");

            Console.WriteLine("\nOpérations arithmétiques\n");
            Console.WriteLine($"({a}) + ({b}) = {a + b} ");
            Console.WriteLine($"({a}) + (2) = {a + 2} ");
            Console.WriteLine($" 3 + ({a})  = {3 + a} ");
            Console.WriteLine($"({a}) - ({b}) = {a - b} ");
            Console.WriteLine($"({a}) - (5) = {a - 5} ");
            Console.WriteLine($"(5) - ({b}) = {5 - b} ");
            Console.WriteLine($"({a}) * ({b}) = {a * b} ");
            Console.WriteLine($"({a}) * (2) = {a * 2} ");
            Console.WriteLine($"(2) * ({b}) = {2 * b} ");
            Console.WriteLine($"({a}) / ({b}) = {a / b} ");
            Console.WriteLine($"({a}) / (2) = {a / 2} ");
            Console.WriteLine($"(1) / ({b}) = {1 / b} ");
            

            Console.WriteLine("\nComparaison\n");
            try
            {
                Console.WriteLine($"({a}) == ({b}) = {a == b} ");
                Console.WriteLine($"({a}) != ({b}) = {a != b} ");
                Console.WriteLine($"(({a}) + ({c})) < (({b}) + ({d})) = {(a + c) < (b + d) } ");
                Console.WriteLine($"(({a}) + ({c})) <= (({b}) + ({d})) = {(a + c) <= (b + d) } ");
                Console.WriteLine($"(({a}) + ({c})) > (({b}) + ({d})) = {(a + c) > (b + d) } ");
                Console.WriteLine($"(({a}) + ({c})) >= (({b}) + ({d})) = {(a + c) >= (b + d) } ");
                Console.WriteLine($"La comparaison ({a}) < ({b}) génère une exception de type: \"OrdreImaginaireException\"\n");
                Console.WriteLine($"({a}) < ({b}) = {a < b} ");
            }
            catch (OrdreImaginaireException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
