namespace DesignPatterns;

public class NetworkFactory
{
    public INetwork instanceOf(string type)
    {
        switch (type.ToLower())
        {
            case "ping": return new Ping();
            case "dns": return new DNS();
            case "arp": return new ARP();
            default:
                System.Console.WriteLine("Now Object Found");
                return null;
        }
    }
}
