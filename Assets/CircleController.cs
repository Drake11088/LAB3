using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    // Start is called before the first frame update
    private int direction = 1;
    private float movespeed = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 movement = new Vector3(0f, direction, 0f);
        transform.Translate(movement * movespeed * Time.deltaTime);

        if(transform.position.y >= 1.3f ||  transform.position.y <= -1.2f)
        {
            direction *= -1;
        }
    }
}
