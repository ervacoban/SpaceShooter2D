using Unity.Netcode;
using Unity.Netcode.Transports.UNET;
using UnityEngine;

public class ServerConnection : NetworkBehaviour
{
    private void Start()
    {
        NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = ConnectionInfo.connectionIP;
        NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectPort = int.Parse(ConnectionInfo.connectionPort);
        NetworkManager.Singleton.GetComponent<UNetTransport>().ServerListenPort = int.Parse(ConnectionInfo.connectionPort);
        if(ConnectionInfo.isHost)
        {
            NetworkManager.Singleton.StartHost();
        }
        else
        {
            NetworkManager.Singleton.StartClient();
        }
    }
}
