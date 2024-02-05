namespace DesignPatterns;

public class Sockets
{
    public string protocal {get; set;}

    public Sockets(string protocal){
        this.protocal = protocal;
    }
    public void connectToSockets(){
        System.Console.WriteLine("Sockets has been readied for "+ protocal);
    }
}
