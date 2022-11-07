using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoPlayer();
    }

    void MovimientoPlayer()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(movX, 0 , movY));

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-5,0);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,5,0);
        }
    }
}