namespace DesignPatterns;

public class DNS : INetwork
{
    public void sendRequest(string ip, int timeout)
    {
        System.Console.WriteLine("Request Sent to " + ip + " , request timedOut in " + timeout + " seconds");
    }
}
