using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

public class ballBehaviour : MonoBehaviour
{
    Rigidbody ballRigidbody;

    void Awake()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }
    public void resetBallPosition()
    {
        transform.position= new Vector3 (0.02f,1f,-0.7f);
        this.ballRigidbody.isKinematic = true;
    }

    public void changeBallRigidbody()
    {
        this.ballRigidbody.isKinematic = false;
    }

}
