using UnityEngine;

public class Rocket : MonoBehaviour
{
    private float lastSpawn;
    private float spawnTime = 0.75f; // every 0.75 seconds a rocket can be shot.
    [SerializeField] private GameObject rocket;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - lastSpawn > spawnTime)
            {
                lastSpawn = Time.time;
                Instantiate(rocket, new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)); // 0.7f -> No collision with Jet
            }
        }
    }
}
