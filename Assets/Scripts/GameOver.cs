using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text score;
    private void Awake()
    {
        score.text = "Score = " + Score.score;
    }

    public void PlayAgain()
    {
        Score.lives = 6;
        Score.score = 0;
        SceneManager.LoadScene("Level");
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
