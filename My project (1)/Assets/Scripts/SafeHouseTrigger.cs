using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeHouseTrigger : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
     if (col.gameObject.tag == "Player")
     {
       Win();
     }
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Win();
        }
    }

    void Win()
    {
     Debug.Log("You Survived!");
     Time.timeScale = 0;
    }

}
