using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float da�o;

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }
    //Revisar que Is Trigger est� encendido en el collider de la bala
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colisi�n de la bala");
        if (other.CompareTag("Enemy"))
        {
            print("Colisi�n con el enemigo");
            other.GetComponent<Enemigo>().TomarDa�o(da�o);
            Destroy(gameObject);
        }
    }
}
