using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;

class Program
{
    static void Main()
    {

        string IP = "192.168.0.15"; //192.168.0.11 
        int totalPings = 4;

        try
        {
            Ping ping = new Ping();


            for (int i = 0; i < totalPings; i++)
            {
                PingReply reply = ping.Send(IP);

                if (reply.Status == IPStatus.Success)
                    Console.WriteLine(reply.Status + "Estatus " +
                        "\n" + reply.RoundtripTime + " MS" +
                        "\n" + reply.Address + " Address \n");

                else Console.WriteLine("Error " + reply.Status);

            }


        }

        catch (PingException ex)
        {
            Console.WriteLine("Error de ping: " + ex.Message);
        }
        catch (SocketException ex)
        {
            Console.WriteLine("Error de socket: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Otro error: " + ex.Message);
        }
    }

}
