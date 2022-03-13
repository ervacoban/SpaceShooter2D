using UnityEngine;

public class RocketCollision : MonoBehaviour
{
    private float speed = 0.1f; // rocket speed

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ufo"))
        {
            Destroy(collision.gameObject);
            Score.score++;
            Destroy(gameObject);
        }
    }
}
