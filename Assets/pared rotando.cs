using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ej2 pared rotacional
public class paredrotando : MonoBehaviour

{
    public float velocidadRotacion = 20.0f; // Velocidad a la que inicialmente empezarian a girar

    void Update()
    {
        // Gira el objeto en el eje z. time delta time hace que en ves de ejecutarse cada frame se ejecute cada segundo lo que permite un cambio gradual 
        transform.Rotate(Vector3.forward * Time.deltaTime * velocidadRotacion); //multiplicamos el vector z (forward) por el tiempo ( time deltatime) y por la velocidad de rotacion ( velocidadRotacion)
    }
}
