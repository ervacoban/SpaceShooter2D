using UnityEngine;
using UnityEngine.UI;

public class PauseContinue : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;
    public Text score;
    private bool paused;

    void Start()
    {
        paused = false;
    }

    void Update()
    {
        if (paused) Time.timeScale = 0;
        else Time.timeScale = 1;
        score.text = "Score = " + Score.score.ToString();
    }

    public void PauseGame()
    {
        paused = true;
        pauseScreen.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        paused = false;
        pauseScreen.SetActive(false);
        pauseButton.SetActive(true);
    }
}