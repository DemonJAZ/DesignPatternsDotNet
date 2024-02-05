namespace DesignPatterns;

public class NetworkFacade
{
    public Packets packets { get; set; }

    public Sockets sockets { get; set; }

    public Transmission transmission { get; set; }

    public NetworkFacade(string ip, string protocal)
    {
        this.packets = new Packets(ip);
        this.sockets = new Sockets(protocal);
        this.transmission = new Transmission(protocal);
    }

    public void BuildNetwork()
    {
        packets.PreparePackets();
        sockets.connectToSockets();
    }

    public void sendTransmission()
    {
        this.BuildNetwork();
        transmission.sendTransmission();
    }
}
