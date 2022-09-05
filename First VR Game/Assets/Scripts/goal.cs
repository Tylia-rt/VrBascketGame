using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class goal : MonoBehaviour
{
    public UnityEvent Ongoal;
    
    void OnTriggerEnter(Collider other)
    {
        Ongoal.Invoke();
    }

    
}
