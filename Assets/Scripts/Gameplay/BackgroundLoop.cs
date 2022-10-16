using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    private List<Transform> backgrounds = new List<Transform>();
    private Vector3 _firstPosition;
    
    private void Start() 
    {
        foreach(Transform child in transform)
        {
            backgrounds.Add(child);
        }
        _firstPosition = backgrounds[0].position;
    }

    private void FixedUpdate()
    {
        foreach(Transform background in backgrounds)
        {
            background.position = new Vector2(background.position.x, background.position.y - speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Background"))
        {
            other.transform.position = _firstPosition;
        }
    }
}
