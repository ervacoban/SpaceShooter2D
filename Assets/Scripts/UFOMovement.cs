using UnityEngine;

public class UFOMovement : MonoBehaviour
{
    private float speed;
    private void Start()
    {
        speed = Random.Range(0.095f, 0.165f);   
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed);
    }
}
