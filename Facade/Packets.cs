namespace DesignPatterns;

public class Packets
{
    public string ip {get; set;}

    public Packets(string ip){
        this.ip = ip;
    }
    public void PreparePackets(){
        System.Console.WriteLine("Packets have been Prepared for destination IP "+ ip);
    }
}   
