using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int score;

    public void scoreChanged()
    {
        score +=1;
    }
}
