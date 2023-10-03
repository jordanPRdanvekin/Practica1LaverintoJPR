using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ej2 pared rotacional
public class paredrotando : MonoBehaviour

{
    public float velocidadRotacion = 1.0f; // Velocidad a la que inicialmente empezarian a girar
    void Start()//solo una ves al iniciar el juego se va a reproducir lo que se programe dentro 
    {
        velocidadRotacion = Random.Range(-30.0f, 30.0f);//con esto aleatorierizare el rango de velociodad de movimiento del objeto 
    }
    void Update()// como start pero en lugar de una ves sera cada frame en bucle infinito 
    {
        // Gira el objeto en el eje z. time delta time hace que en ves de ejecutarse cada frame se ejecute cada segundo lo que permite un cambio gradual 
        transform.Rotate(Vector3.forward * Time.deltaTime * velocidadRotacion); //multiplicamos el vector z (forward) por el tiempo ( time deltatime) y por la velocidad de rotacion ( velocidadRotacion)
    }
}
