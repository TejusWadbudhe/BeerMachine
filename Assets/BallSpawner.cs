using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 0.5f);
    }

    // Update is called once per frame
    void Spawn()
    {
        GameObject obj = Instantiate(ballPrefab, this.transform.position, Quaternion.identity);
        obj.transform.parent = this.transform;
    }
}
//Quaternion.identity for no rotation