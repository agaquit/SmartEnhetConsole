using System.Net.NetworkInformation;

namespace AdvancedDevice.Services;

internal class NetworkManager
{
    private static readonly Ping ping = new ();
    private static bool isConnected = false;
    private static int heartbeatInterval = 10000;


    public static bool GetConnectedStatus () => isConnected;



    public static async Task CheckConnectivityAsync()
    {
        while (true)
        {
            isConnected = await SendPingAsync("8.8.8.8");
            Console.WriteLine(isConnected ? "Connected" : "Disconnected");
            await Task.Delay (heartbeatInterval);


        }
    }

    private static async Task<bool> SendPingAsync(string ipAddress)
    {
        try
        {
            var reply = await ping.SendPingAsync(ipAddress);
            return reply.Status == IPStatus.Success;    

        } catch (Exception ex) { return false;}

    }

}
