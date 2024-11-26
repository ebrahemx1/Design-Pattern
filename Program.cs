using Design.Ex01;
using Design.Ex01.Strategys;
using System;

#region Encapsulate What Varies 
StandardPricing standard = new StandardPricing();

DisscountPricing dis = new DisscountPricing(){DisscountAmount = 30};

Product p = new Product()
{
    BasePrice =100,
};

var result = p.CalculateProductPrice(dis);
Console.WriteLine(result);
#endregion

