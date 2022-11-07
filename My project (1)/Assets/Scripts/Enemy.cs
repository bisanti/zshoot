using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform PlayerPos;
    public float maxDistance = 5f;
    public float Speed = 2f; 
    public Comportamiento Compor;
    public enum Comportamiento
    {
     Look,
     GoTowards
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(Compor)
        {
            case Comportamiento.Look:
            LookAtPlayer();
            break;            

            case Comportamiento.GoTowards:
            FollowPlayer();
            LookAtPlayer();
            break;

        }
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos.position, Speed * Time.deltaTime);

        float dist = Vector3.Distance(PlayerPos.position, transform.position);
        

    }

    void LookAtPlayer()
    {
        transform.LookAt(PlayerPos);
    }
}
