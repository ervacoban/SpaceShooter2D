using UnityEngine;

public class Edges : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket")) Destroy(collision.gameObject);
        if (collision.gameObject.CompareTag("Ufo"))
        {
            Destroy(collision.gameObject);
            Score.lives--;
            Score.changed = true;
        }
    }
}
