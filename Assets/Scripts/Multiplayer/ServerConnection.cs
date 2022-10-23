using Unity.Netcode;
using Unity.Netcode.Transports.UNET;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Collections;


public class ServerConnection : NetworkBehaviour
{
    [SerializeField] private GameObject _clientsUsername;
    private NetworkList<FixedString32Bytes> _clients = new NetworkList<FixedString32Bytes>();
    
    private void Start()
    {
        _clients.OnListChanged += UpdateClientList;
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

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        UpdateListServerRpc(ConnectionInfo.username, true);
    }

    [ServerRpc(RequireOwnership = false)]
    private void UpdateListServerRpc(string name, bool addName)
    {
        if(addName)
            _clients.Add(name);

        else
            _clients.Remove(name);
    }

    private void UpdateClientList(NetworkListEvent<FixedString32Bytes> clientName)
    {
        Debug.Log(clientName.Value);
    }
}
