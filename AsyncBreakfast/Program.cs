

using AsyncBreakfast;

Coffee cup = Cook.PourCoffee();
Console.WriteLine("coffee is ready");

var eggsTask = Cook.FryEggsAsync(2);
var baconTask = Cook.FryBaconAsync(3);
var toastTask = Cook.MakeToastWithButterAndJamAsync(2);

var eggs = await eggsTask;
Console.WriteLine("eggs are ready");

var bacon = await baconTask;
Console.WriteLine("bacon is ready");

var toast = await toastTask;
Console.WriteLine("toast is ready");

Juice oj = Cook.PourOJ();
Console.WriteLine("oj is ready");
Console.WriteLine("Breakfast is ready!");