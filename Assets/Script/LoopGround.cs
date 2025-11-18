using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopGround : MonoBehaviour
{
    
    private float groundLength = 900f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.parent.position += new Vector3(0, 0, groundLength * 2);
        }
    }
}
