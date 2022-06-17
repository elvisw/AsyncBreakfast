

using AsyncBreakfast;

Coffee cup = Cook.PourCoffee();
Console.WriteLine("coffee is ready");

var eggsTask = Cook.FryEggsAsync(2);
var baconTask = Cook.FryBaconAsync(3);
var toastTask = Cook.MakeToastWithButterAndJamAsync(2);

var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
while (breakfastTasks.Count > 0)
{
    Task finishedTask = await Task.WhenAny(breakfastTasks);
    if (finishedTask == eggsTask)
    {
        Console.WriteLine("eggs are ready");
    }
    else if (finishedTask == baconTask)
    {
        Console.WriteLine("bacon is ready");
    }
    else if (finishedTask == toastTask)
    {
        Console.WriteLine("toast is ready");
    }
    breakfastTasks.Remove(finishedTask);
}