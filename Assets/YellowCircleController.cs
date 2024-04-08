using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleYellowController : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject player;
    private int count = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        count++;
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

        Vector3 direction = (player.transform.position - prefabToSpawn.transform.position).normalized;

        prefabToSpawn.GetComponent<Rigidbody>().velocity = direction * 2f;
    }
}