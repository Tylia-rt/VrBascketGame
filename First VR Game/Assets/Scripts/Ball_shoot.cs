using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_shoot : MonoBehaviour
{
Rigidbody rb;
public float force;
public float x;

public Transform playerTransform;

    void Start()
    {
        //------- cherche le compo du rigidbody et lui ajoute une force vers le haut (up)
        rb =  GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force); 

    }

    //----FixedUpdate 60FPS d'office . A UTILISER LORS CE QU'ON UTILISE LA PHYSIQUE---- //
    //void FixedUpdate()

    void OnCollisionEnter(Collision collision)
    {   //if(collision.collider.tag == "nope") Alternative
        if(!collision.collider.CompareTag ("nope")){
            if(Vector3.Angle(collision.GetContact(0).normal,Vector3.up) <= 45){

            playerTransform.position = collision.GetContact(0).point;
            Destroy(gameObject);
        }
            }

    }

}

