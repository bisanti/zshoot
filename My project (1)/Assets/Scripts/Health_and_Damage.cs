using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_Damage : MonoBehaviour
{
    public int vida = 100;
    public bool invencible = false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.1f;


    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void RestarVida(int cantidad)
    {
        if (!invencible && vida > 0)
        {
            vida -= cantidad;
            anim.Play("GetHit");
            StartCoroutine(Invulnerabilidad());
            StartCoroutine(FrenarVelocidad());

            if (vida == 0)
            {
                GameOver();
            }
        }
    }

    public void SumarVida(int LifeUp)
    {
        vida = Mathf.Clamp(vida, 0, 100);
        
        if (!invencible && vida < 100)
        { 
            vida += LifeUp;
            {
                Lifepoints();
            }
        }
    }

    void Lifepoints()
    {
        Debug.Log("Lifepoints Up!");
        Time.timeScale = 1f;
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0;
    }

    IEnumerator Invulnerabilidad()
    {
        invencible = true;
        yield return new WaitForSeconds(tiempo_invencible);
        invencible = false;

    }

    IEnumerator FrenarVelocidad()
    {
        var velocidadActual = GetComponent<PlayerController>().playerSpeed;
        GetComponent<PlayerController>().playerSpeed = 0;
        yield return new WaitForSeconds(tiempo_frenado);
        GetComponent<PlayerController>().playerSpeed = velocidadActual;
    }
}
