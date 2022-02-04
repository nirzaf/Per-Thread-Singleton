public sealed class PerThreadSingleton
{
    private static ThreadLocal<PerThreadSingleton> threadInstance
        = new ThreadLocal<PerThreadSingleton>(
            () => new PerThreadSingleton());

    public int Id;

    private PerThreadSingleton()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
    }

    public static PerThreadSingleton Instance => threadInstance.Value;
}