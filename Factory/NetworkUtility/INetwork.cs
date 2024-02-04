namespace DesignPatterns;

public interface INetwork
{
    void sendRequest(string ip, int timeout);
}
