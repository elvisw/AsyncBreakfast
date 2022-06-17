

using AsyncBreakfast;

Coffee cup = Cook.PourCoffee();
Console.WriteLine("coffee is ready");

Egg eggs = Cook.FryEggs(2);
Console.WriteLine("eggs are ready");

Bacon bacon = Cook.FryBacon(3);
Console.WriteLine("bacon is ready");

Toast toast = Cook.ToastBread(2);
Cook.ApplyButter(toast);
Cook.ApplyJam(toast);
Console.WriteLine("toast is ready");

Juice oj = Cook.PourOJ();
Console.WriteLine("oj is ready");
Console.WriteLine("Breakfast is ready!");