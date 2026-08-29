using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")

            print("Hit");

        
    }
  
}
