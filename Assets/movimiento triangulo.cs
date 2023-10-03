using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ejemplo 1: Movimiento del tri�ngulo con salto y colisiones
public class MovimientoTriangulo : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Velocidad de movimiento del tri�ngulo
    public Rigidbody2D fisicas; //variable para llamar al rigidbody
    public float fuerzaSalto = 10f; // Fuerza del salto
    private bool enSuelo = true; // Variable para verificar si el tri�ngulo est� en el suelo

    // Este m�todo se llama al inicio del juego
    void Start()
    {
        // Inicializar la variable de enSuelo en true ya que el tri�ngulo comienza en el suelo
        enSuelo = true;
        //con esto nos ahorramos tener que repetir el comando get componet pues fisicas es igual a dicho codigo
        fisicas = GetComponent<Rigidbody2D>();  
    }

    // Este m�todo se llama en cada fotograma
    void Update()
    {
        // Obtener la entrada horizontal del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento horizontal no uses time delta a no ser que tengas que mover algo a lo largo del tiempo 
        var movimiento =velocidadMovimiento * new Vector3(movimientoHorizontal, movimientoVertical, 0);

        // Mover el tri�ngulo en la direccion pulsada
        fisicas.velocity = movimiento;

        // Verificar si el jugador presiona la tecla de salto y est� en el suelo
        if (Input.GetButtonDown("Jump") && enSuelo)
        {
            // Aplicar una fuerza hacia arriba para simular el salto
            fisicas.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

            // Cambiar la variable enSuelo a false para evitar m�ltiples saltos en el aire
            enSuelo = false;
        }
    }

    // Este m�todo se llama cuando el objeto colisiona con otro objeto
    void OnCollisionEnter2D(Collision2D colision)
    {
        // Verificar si la colisi�n es con un objeto etiquetado como "Suelo"
        if (colision.gameObject.CompareTag("suelo"))
        {
            // Cambiar la variable enSuelo a true para indicar que estamos en el suelo
            enSuelo = true;
            
        }

    }
}
