using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    [SerializeField] private GameObject[] backgroundUI;
    private int lastBackgroundID = 0;

    void Update()
    {
        if (backgroundUI[lastBackgroundID].transform.position.y < -8)
        {
            backgroundUI[lastBackgroundID].transform.position = new Vector2(backgroundUI[lastBackgroundID].transform.position.x, 8);
            lastBackgroundID++;
            if (lastBackgroundID == 2) lastBackgroundID = 0;
        }
    }

    private void FixedUpdate()
    {
        float speed = 0.1f;
        backgroundUI[0].transform.position = new Vector2(backgroundUI[0].transform.position.x, backgroundUI[0].transform.position.y - speed);
        backgroundUI[1].transform.position = new Vector2(backgroundUI[1].transform.position.x, backgroundUI[1].transform.position.y - speed);
    }
}
