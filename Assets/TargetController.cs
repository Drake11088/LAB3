using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetController : MonoBehaviour
{
    public int scoreValue = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            
            ScoreController.Instance.IncreaseScore(scoreValue);

            
            Destroy(gameObject); 
            Destroy(collision.gameObject); 
        }
    }
}