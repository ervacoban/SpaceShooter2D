using UnityEngine;

public class SpawnUFO : MonoBehaviour
{
    private float lastSpawn;
    private float spawnTime = 1.0f; // Every 1 second an UFO spawns.
    [SerializeField] private GameObject ufo;

    void Update()
    {
        if (Time.time - lastSpawn > spawnTime)
        {
            lastSpawn = Time.time;
            Instantiate(ufo, new Vector3(Random.Range(-3.3f, 3.3f), 4.5f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
        }
    }
}
