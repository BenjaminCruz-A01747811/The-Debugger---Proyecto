using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float daño2;
    //[SerializeField] private Transform ColisionDaño;

    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colisión del enemigo");
        if (other.CompareTag("Player"))
        {
            print("Colisión con el jugador");
            other.GetComponent<Jugador>().TomarDanio(daño2);
            Destroy(gameObject);
        }
    }
}