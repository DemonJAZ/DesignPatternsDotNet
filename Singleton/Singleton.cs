namespace DesignPatterns;

public class Singleton
{
    static Singleton instance;

    public string setting { get; set; } = "Color: Blue";

    protected Singleton() { }

    public static Singleton Instance()
    {
        if (instance is null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
