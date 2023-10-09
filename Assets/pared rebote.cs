using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredrebote : MonoBehaviour
{
    public float movimiento = 1.0f; // movimiento base del objeto
    public float tiempo = 0.0f;//marca el tiempo trascurrido desde el inicio del juego 
    private bool derecha = true;//activa la condicional derecha 

    void Start()//solo una ves al iniciar el juego se va a reproducir lo que se programe dentro en este caso no es necesario 
    {
       
    }
    void Update()// como start pero en lugar de una ves sera cada frame en bucle infinito 
    {
        tiempo += Time.deltaTime; //aqui le pido que sume el tiempo trascurrido por el tiempo base
        if (tiempo >= 4.0f) //a partir de aqui cada 4 segundos va a repetir la accion de aplicar la direccion opuesta horizontal a los cuadros ademas de resetear el tiempo a cero cada ves que supere los 4 segundos
        {
            derecha = !derecha;
            tiempo = 0.0f;
        }
        if (derecha)
        {
            transform.Translate(Vector2.right * movimiento * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * movimiento * Time.deltaTime);
        }
    }

}
