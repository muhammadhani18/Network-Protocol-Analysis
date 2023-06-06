using static System.Console;
using static CANAPE.Cli.ConsoleUtils;

//create proxy template
var template = new FixedProxyTemplate();
template.LocalPort = 8080;
template.Host = "192.168.15.1";
template.Port = 80;

//Create proxy instance and start
var service = template.Create();
service.Start();

WriteLine("Created{0}", service);
WriteLine("Press enter to exit");
Readline();
service.Stop();

//Dump packets
var packets = service.Packets;
WriteLine("Captures{0} packets: ", packets.Count);
WritePackets(packets);
