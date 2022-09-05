using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class player : MonoBehaviour
{
    public UnityEvent whenBallIsTooFar;
    public int score;
    public GameObject ball;
    public GameObject bascketNet;

    public void scoreChanged()
    {
        score +=1;
    }

    void Update()
    {
        verifyBallToFar(ball, bascketNet);
    }
    public void verifyBallToFar(GameObject ball, GameObject bascketnet)
    {
        float distancePlayerBall = Vector3.Distance(transform.position, ball.transform.position);
        float distancePlayerBascketNet = Vector3.Distance(transform.position, bascketNet.transform.position);

        if(distancePlayerBall > distancePlayerBascketNet)
        {
            whenBallIsTooFar.Invoke();
        }

    }
}
