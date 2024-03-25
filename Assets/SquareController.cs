using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading;
using Unity.Profiling.Editor;
using Unity.VisualScripting;

public class SquareController : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 60;
    public Text countdownText;
    void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1);
            timeRemaining--;
            countdownText.text = "Time: " + timeRemaining.ToString();
        }
        countdownText.text = "Time's Up!";
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        transform.Translate(translation: movement * 3f * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Circle"))
        {
            Debug.Log("XXXX");
            Vector2 firstPosition = new Vector2(0, 4);
            transform.position = firstPosition;
        }
        if(collision.gameObject.name.Equals("Box"))
        {
            Debug.Log("xxxx");
            LoadNextScene();
        }
        if(collision.gameObject.name.Equals("PinWheel"))
        {
            Debug.Log("XXXX");
            Vector2 firstPosition = new Vector2(0, 4);
            transform.position = firstPosition;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("MapEdge"))
        {
            Debug.Log("xxxxxx");
            Vector2 firstPosition = new Vector2(0, 4);
            transform.position = firstPosition;
        }
        if(collision.gameObject.name.Equals("MapEdge"))
        {
            Debug.Log("XXXX");
            Vector2 firstPosition = new Vector2(0, 4);
            transform.position = firstPosition;
        }    
    }
}
