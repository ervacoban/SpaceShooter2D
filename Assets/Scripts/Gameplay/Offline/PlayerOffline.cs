using UnityEngine;

public class PlayerOffline : MonoBehaviour
{
    [SerializeField] private GameObject _pauseScreen, _pauseButton;
    [SerializeField] private float moveSpeed;
    private bool gamePaused;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseContinue();
        }
    }

    private void FixedUpdate()
    {
        //transform.position = new Vector2(transform.position.x + moveSpeed * Input.GetAxis("Horizontal"), transform.position.y + moveSpeed * Input.GetAxis("Vertical"));
        if (Input.GetKey(KeyCode.A) && transform.position.x > -8) 
            transform.position = new Vector2(transform.position.x - moveSpeed, transform.position.y); 

        else if (Input.GetKey(KeyCode.D) && transform.position.x < 8) 
            transform.position = new Vector2(transform.position.x + moveSpeed, transform.position.y);

        if (Input.GetKey(KeyCode.W) && transform.position.y < 0) 
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed); 

        else if (Input.GetKey(KeyCode.S) && transform.position.y > -4) 
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);
    }

    public void PauseContinue()
    {
        gamePaused = !gamePaused;
        _pauseScreen.SetActive(gamePaused);
        _pauseButton.SetActive(!gamePaused);
        Time.timeScale = System.Convert.ToSingle(!gamePaused);
    }
}
