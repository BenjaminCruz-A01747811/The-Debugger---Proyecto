using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float da�o2; // Nuevo

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colisi�n del enemigo");
        if (other.CompareTag("Player"))
        {
            print("Colisi�n con el jugador");
            other.GetComponent<Jugador>().TomarDa�o2(da�o2); // Nuevo
            print("El jugador ha recibido da�o");
            Destroy(gameObject);
        }
    }
}
