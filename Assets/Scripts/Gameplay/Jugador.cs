using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] private float vida;

    public void TomarDanio(float da�o2)
    {
        vida -= da�o2;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}

