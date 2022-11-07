using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
   public int cantidad = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Health_and_Damage>().RestarVida(cantidad);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Health_and_Damage>().RestarVida(cantidad);
        }
    }

        private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Health_and_Damage>().RestarVida(cantidad);
        }
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Health_and_Damage>().RestarVida(cantidad);
        }
    }

}
