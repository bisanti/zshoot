using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempoSonidos : MonoBehaviour
{
    public AudioSource Disparo;
    public AudioSource Aullido;
    public float tiempo = 20f;
    public float tiempo2 = 30f;

    public float resetTiempo = 20f;
    void Start()
    {
        
    }

    
    void Update()
    {
        temporizador();
        temporizador2();

    }
     void temporizador()
    {
     tiempo -= Time.deltaTime;
    Debug.Log (tiempo);
    if(tiempo <=2)
    {
        tiempo = resetTiempo;
        Disparo.Play();
    }
     
    }

     void temporizador2()
     {
     tiempo2 -= Time.deltaTime;
    Debug.Log (tiempo2);
    if(tiempo2 <=5)
    {
        tiempo2 = resetTiempo;
        Aullido.Play();
    }
     
    }
}
