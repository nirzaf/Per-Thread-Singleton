using static System.Console;


Task t1 = Task.Factory.StartNew(() =>
{
    WriteLine($"t1: " + PerThreadSingleton.Instance.Id);
});
Task t2 = Task.Factory.StartNew(() =>
{
    WriteLine($"t2: " + PerThreadSingleton.Instance.Id);
    WriteLine($"t2 again: " + PerThreadSingleton.Instance.Id);
});
Task.WaitAll(t1, t2);