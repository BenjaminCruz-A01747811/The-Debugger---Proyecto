using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float daño;

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }
    //Revisar que Is Trigger esté encendido en el collider de la bala
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colisión de la bala");
        if (other.CompareTag("Enemy"))
        {
            print("Colisión con el enemigo");
            other.GetComponent<Enemigo>().TomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
