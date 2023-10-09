using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ej2 pared rotacional
public class paredrotando : MonoBehaviour

{
    public float velocidadRotacion = 1.0f; // Velocidad a la que inicialmente empezarian a girar
    public float tiempo = 0.0f;//marca el tiempo trascurrido desde el inicio del juego 
    void Start()//solo una ves al iniciar el juego se va a reproducir lo que se programe dentro 
    {
        velocidadRotacion = Random.Range(-100.0f, 100.0f);//con esto aleatorierizare el rango de velociodad de movimiento del objeto 
    }
    void Update()// como start pero en lugar de una ves sera cada frame en bucle infinito 
    {
        tiempo += Time.deltaTime; //aqui le pido que sume el tiempo trascurrido por el tiempo base
        if (tiempo >= 10.0f) //a partir de aqui cada 10 segundos va a repetir la accion de aplicar una velocidad aleatoria a los cuadros ademas de resetear el tiempo a cero cada ves que supere los 10 segundos
        {
            velocidadRotacion = Random.Range(-100.0f, 100.0f);
            tiempo = 0.0f;
        }
        // Gira el objeto en el eje z. time delta time hace que en ves de ejecutarse cada frame se ejecute cada segundo lo que permite un cambio gradual 
        transform.Rotate(Vector3.forward * Time.deltaTime * velocidadRotacion); //multiplicamos el vector z (forward) por el tiempo ( time deltatime) y por la velocidad de rotacion ( velocidadRotacion)
    }
}
