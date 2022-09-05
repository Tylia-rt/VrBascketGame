using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bascketNet : MonoBehaviour
{
    public GameObject player;
    public GameObject avoidRotatingTowardsGround;

    // Update is called once per frame
    void Update()
    {
        
        avoidRotatingTowardsGround.transform.position = new Vector3 (player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.LookAt(avoidRotatingTowardsGround.transform);
    }

    public void GenerateNewLocation()
    {
        transform.position = new Vector3(Random.Range(-4,4), Random.Range(2,4), Random.Range(-4,4));
    }
    
}
