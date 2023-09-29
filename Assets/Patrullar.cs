using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullar : MonoBehaviour
{
   [SerializeField] private float velocidadMovimiento;
   [SerializeField] private transform[] puntosMovimientos;
   [SerializeField] private float distanciaMinima;
   private int numeroAleatorio;
   private SpriteRenderer SpriteRenderer;


   private void Start(){
    numeroAleatorio = Random.Range(0, puntosMovimientos.Length);
    SpriteRenderer = GetComponent<SpriteRenderer>();
   }
   private void Update(){
    transform.position = Vector2.MoveTowards(transform.position, puntosMovimientos[numeroAleatorio].position, velocidadMovimiento * Time.deltaTime);
    if(Vector2.Distance(transform.position, puntosMovimientos[numeroAleatorio].position)<distanciaMinima){
        
    }
   }

}

