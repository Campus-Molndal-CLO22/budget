using budget.entity;
using Microsoft.EntityFrameworkCore;

namespace budget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var inkomster = db.Set<Inkomster>();
                var utgifter = db.Set<Utgifter>();
                
                foreach (var inkomst in inkomster)
                {
                    Console.WriteLine(inkomst.Lön);
                    Console.WriteLine(inkomst.Bidrag);
                }
                foreach (var utgift in utgifter)
                {
                    Console.WriteLine(utgift.Hyra);
                    Console.WriteLine(utgift.Netflix);
                    Console.WriteLine(utgift.Bredband);
                    Console.WriteLine(utgift.Busskort);
                    Console.WriteLine(utgift.Mat);
                    Console.WriteLine(utgift.Försäkring);
                    Console.WriteLine(utgift.Gym);
                }

                
            }
            
        }
    }
}