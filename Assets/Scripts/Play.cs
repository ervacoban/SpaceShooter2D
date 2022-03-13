using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene("Level");
    }
}
