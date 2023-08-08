using Internal;
using System;
using System.Reflection;

Person p = new Person();
Person p2 = new Person("Hans", "Hansen");

Console.WriteLine($"{p.SayHello()}");
Console.WriteLine($"{p2.SayHello()}");

køretøj<double> bil = new("audi", "a6", 134);
Console.WriteLine($"Bilinfo: {bil.GetAllKøretøjinfo()}");

MethodBase? GetAllKøretøjinfoMethod = bil.GetType().GetMethods().FirstOrDefault();
var myMethodAttributes = bil.GetType().GetCustomAttribute().of<ulovligkøretøj>();

Console.WriteLine($"minBilTypeClass: {ulovligAttribute.mærke} {ulovligAttribute.model}");
Console.WriteLine($"minBilTypeMethod: {myMethodAttributes.mærke} {myMethodAttributes.model}");
Console.WriteLine($"Valgt af tilvage kalde bil er: {}");

memberinfo[] memberinfo =TilbageKaldteBilerEnum.GetType().GetMember(TilbageKaldteBilerEnum.tostring());
TilbagekaldteBilerAttributter? selectedAttribute = (TilbagekaldteBilerAttributter)memberinfo[0].GetCustomAttribute(typeof(TilbagekaldteBilerAttributter));
Console.WriteLine($"selectedAttribute: {selectedAttribute.mærke} {selectedAttribute.model}");