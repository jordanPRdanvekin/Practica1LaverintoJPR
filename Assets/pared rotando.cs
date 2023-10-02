using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ej2 pared rotacional
public class paredrotando : MonoBehaviour
{
    // Uso estas variables para almacenar la x e y de la escala
    float escalaX, escalaY;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            escalaX = transform.localScale.x;
            escalaY = transform.localScale.y;
            transform.localScale = new Vector2(escalaX - 0.5f
                , escalaY - 0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            escalaX = transform.localScale.x;
            escalaY = transform.localScale.y;
            transform.localScale = new Vector2(escalaX + 0.5f
                , escalaY + 0.5f);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            // No hace falta usar Time.deltaTime ya que no queremos rotar
            // de forma constante a lo largo del tiempo
            transform.Rotate(45 * Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            // No hace falta usar Time.deltaTime ya que no queremos rotar
            // de forma constante a lo largo del tiempo
            transform.Rotate(45 * Vector3.back);
        }
    }
}
