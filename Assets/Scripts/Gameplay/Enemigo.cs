using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float daño2;
    [SerializeField] private float tiempoEntreDaño;
        
    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private float tiempoSiguienteDaño;

    private void OnTriggerStay2D(Collider2D other)
    {
        print("Colisión del enemigo");
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if(tiempoSiguienteDaño <= 0)
            {
                print("Colisión con el jugador");
                other.GetComponent<Jugador>().TomarDaño2(daño2);
                Destroy(gameObject);
            }
        }
    }
}