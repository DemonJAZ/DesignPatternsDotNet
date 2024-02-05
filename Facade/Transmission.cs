namespace DesignPatterns;

public class Transmission
{
    public string protocal { get; set; }

    public Transmission(string protocal)
    {
        this.protocal = protocal;
    }

    public void sendTransmission()
    {
        System.Console.WriteLine("Tramission initiated via " + protocal);
    }
}
