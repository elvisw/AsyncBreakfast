

using AsyncBreakfast;

Coffee cup = Cook.PourCoffee();
Console.WriteLine("Coffee is ready");

Task<Egg> eggsTask = Cook.FryEggsAsync(2);
Task<Bacon> baconTask = Cook.FryBaconAsync(3);
Task<Toast> toastTask = Cook.ToastBreadAsync(2);

Toast toast = await toastTask;
Cook.ApplyButter(toast);
Cook.ApplyJam(toast);
Console.WriteLine("Toast is ready");
Juice oj = Cook.PourOJ();
Console.WriteLine("Oj is ready");

Egg eggs = await eggsTask;
Console.WriteLine("Eggs are ready");
Bacon bacon = await baconTask;
Console.WriteLine("Bacon is ready");

Console.WriteLine("Breakfast is ready!");