using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] private float vida;

    public void TomarDanio(float daño2)
    {
        vida -= daño2;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}

