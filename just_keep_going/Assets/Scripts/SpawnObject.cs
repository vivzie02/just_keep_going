using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
 
    public GameObject[] objects;
    public GameObject levelHandler;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
        Instantiate(levelHandler, transform.position, Quaternion.identity);
    }

}

