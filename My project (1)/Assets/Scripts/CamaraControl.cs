using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    // Camera TP
    public float rotSpeed;
    public float rotMin, rotMax;
    float mouseX, mouseY;
    public Transform target, Player;

    public Vector3 offset;
    [Range(0, 1)] public float lerpValue;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }



    // Update is called once per frame


    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);

    }
}
