using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_InputField _ipInputHost, _portInputHost, _ipInputClient, _portInputClient, _usernameHost, _usernameClient;
    [SerializeField] private TextMeshProUGUI _errorMessageUIHost, _errorMessageUIClient;
    private string connectionIP, connectionPort, username;
    private TextMeshProUGUI _errorMessageUI;

    public void ConnectToServer(bool isHost)
    {
        if(isHost)
        {
            connectionIP = _ipInputHost.text;
            connectionPort = _portInputHost.text;
            username = _usernameHost.text;
            _errorMessageUI = _errorMessageUIHost;
        }
        else
        {
            connectionIP = _ipInputClient.text;
            connectionPort = _portInputClient.text;
            username = _usernameClient.text;
            _errorMessageUI = _errorMessageUIClient;
        }

        if(!CorrectInputCheck(connectionIP, connectionPort, username))
        {
            _errorMessageUI.text = "Wrong Input!";
            return;
        }

        ConnectionInfo.isHost = isHost;
        ConnectionInfo.connectionIP = connectionIP;
        ConnectionInfo.connectionPort = connectionPort;
        ConnectionInfo.username = username;
        ChangeScene("Lobby");
    }

    private bool CorrectInputCheck(string ip, string port, string username)
    {
        Regex ipCheck = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        Regex portCheck = new Regex(@"^([1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$");
        Regex usernameCheck = new Regex(@"^[A-Za-z0-9]+$");

        if(!ipCheck.IsMatch(ip))
            return false;
        
        if(!portCheck.IsMatch(port))
            return false;

        if(!usernameCheck.IsMatch(username))
            return false;

        return true;
    }
    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
