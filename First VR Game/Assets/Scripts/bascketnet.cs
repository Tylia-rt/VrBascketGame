using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class bascketnet : MonoBehaviour
{
    public UnityEvent goal;
    void OnTriggerEnter(Collider other)
    {
        goal.Invoke();
    }
}
