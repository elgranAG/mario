using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aplastar : MonoBehaviour
{
           private void OnTriggerEnter(Collider collision)
    {
        // Comprueba si el objeto que cayó encima cumple con ciertos criterios (puedes personalizar esto).
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destruye este objeto cuando el jugador cae encima.
            Destroy(gameObject);
        }
    }
}
