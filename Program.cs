// See https://aka.ms/new-console-template for more information

using DesignPatterns;

#region Singleton Pattern

Singleton object1 = Singleton.Instance();
Singleton object2 = Singleton.Instance();

if (object1 == object2)
{
    Console.WriteLine("They are same, Hence Singleton");
}
#endregion

#region Factory Pattern
NetworkFactory networkFactory = new NetworkFactory();
var ping = networkFactory.instanceOf("Ping");
var dns = networkFactory.instanceOf("DNS");
var arp = networkFactory.instanceOf("ARP");

ping.sendRequest("1.1.1.2", 2);
dns.sendRequest("1.2.4.5", 3);
arp.sendRequest("4.3.4.5", 6);
#endregion

#region Facade Pattern
NetworkFacade networkFacade = new NetworkFacade("1.2.3.4","SMTP");
networkFacade.sendTransmission();
#endregion

