using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float da�o2;
    [SerializeField] private float tiempoEntreDa�o;
        
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private float tiempoSiguienteDa�o;

    private void OnTriggerStay2D(Collider2D other)
    {
        print("Colisi�n del enemigo");
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDa�o -= Time.deltaTime;
            if(tiempoSiguienteDa�o <= 0)
            {
                print("Colisi�n con el jugador");
                other.GetComponent<Jugador>().TomarDa�o2(da�o2);
                Destroy(gameObject);
            }
        }
    }
}