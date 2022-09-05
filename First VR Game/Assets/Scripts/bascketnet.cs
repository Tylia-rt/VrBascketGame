using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bascketNet : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }

    public void GenerateNewLocation()
    {
        transform.position = new Vector3(Random.Range(-4,4), Random.Range(0.1f,3), Random.Range(-4,4));
    }
    
}
