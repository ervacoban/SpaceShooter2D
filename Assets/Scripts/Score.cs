using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] private GameObject[] healthUI;
    public static bool changed = false;
    public static int score = 0;
    public static int lives = 6;

    private void Update()
    {
        if (changed)
        {
            healthUI[lives].gameObject.SetActive(false);
            changed = false;
        }

        if (lives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
