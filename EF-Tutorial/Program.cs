using Microsoft.EntityFrameworkCore;

namespace EF_Tutorial;

internal class Program {

    static void Main(string[] args) {
        
        var context = new AppDbContext();

        var requestLines = context.RequestLines.Include(x => x.Request).Include(x => x.Product).ToList();            // to include the vendor inside of the product

        requestLines.ForEach(r => Console.WriteLine($"{r.Request!.Description} | {r.Product!.Name} | {r.Quantity} | {r.Product!.Price:C} | {r.Quantity * r.Product!.Price:C}"));
        var total = context.RequestLines.Include(x => x.Product).Sum(x => x.Quantity * x.Product!.Price);
        Console.WriteLine($"Total: {total:C}");
       
    }
}
