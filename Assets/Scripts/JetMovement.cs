using UnityEngine;

public class JetMovement : MonoBehaviour
{
    float speed = 0.2f, yAxis = -3.3f;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) transform.position = new Vector2(transform.position.x - speed, yAxis); 
        if (Input.GetKey(KeyCode.D)) transform.position = new Vector2(transform.position.x + speed, yAxis);
    }
}
