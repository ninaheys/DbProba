using webshop.Data;
using webshop.Models;

var all = File.ReadAllLines("webshop_rendelesek.csv").Skip(1);
var db = new WebshopContext();

if (!db.Orders.Any())
{
    foreach (var line in all) db.Orders.Add(new Order(line));
    db.SaveChanges();
}

var osszesDatumSzerint = db.Orders.OrderBy(o => o.OrderDate).ToList();
Console.WriteLine("\nÖsszes megrendelés dátum szerinti sorrendben: ");
foreach (var item in osszesDatumSzerint)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Megrendelések száma: {db.Orders.Count()}");

var osszesen = db.Orders.Sum(o => o.UnitPrice * o.Quantity);
Console.WriteLine($"Összes bevétel: {osszesen}");

var topProduct = db.Orders.AsEnumerable().GroupBy(o => o.Product).OrderByDescending(g => g.Sum(o => o.Quantity)).First();
Console.WriteLine($"Legnépszerűbb termék: {topProduct.Key}, Bevétel: {topProduct.Sum(o => o.TotalPrice)}");

var customer = db.Orders.GroupBy(x => x.CustomerName);
var kisKedvenc = customer.AsEnumerable().OrderByDescending(g => g.Sum(g => g.TotalPrice)).First();
Console.WriteLine($"A kedvenc vásárlónk: {kisKedvenc.Key}");

var ertekesek = db.Orders.Where(x => x.UnitPrice > 100000);
Console.WriteLine("\nÉrtékesek: ");
foreach (var item in ertekesek)
{
    Console.WriteLine(item);
}

var rendelesek = customer.AsEnumerable().OrderBy(x => x.Sum(g => g.Quantity)).ToList();
foreach (var item in rendelesek)
{ 
    Console.Write(item.Key+" ");
    Console.WriteLine(item.Sum(x=>x.Quantity)+" termék");
}
