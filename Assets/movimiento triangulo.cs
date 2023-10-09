using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ejemplo 1: Movimiento del triángulo con salto y colisiones
public class MovimientoTriangulo : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Velocidad de movimiento del triángulo
    public Rigidbody2D fisicas; //variable para llamar al rigidbody
    public float fuerzaSalto = 10f; // Fuerza del salto
    private bool enSuelo = true; // Variable para verificar si el triángulo está en el suelo

    // Este método se llama al inicio del juego
    void Start()
    {
        // Inicializar la variable de enSuelo en true ya que el triángulo comienza en el suelo
        enSuelo = true;
        //con esto nos ahorramos tener que repetir el comando get componet pues fisicas es igual a dicho codigo
        fisicas = GetComponent<Rigidbody2D>();
    }

    // Este método se llama en cada fotograma
    void Update()
    {
        // Obtener la entrada horizontal del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento horizontal no uses time delta a no ser que tengas que mover algo a lo largo del tiempo 
        var movimiento = velocidadMovimiento * new Vector3(movimientoHorizontal, movimientoVertical, 0);

        // Mover el triángulo en la direccion pulsada
        fisicas.velocity = movimiento;

        // Verificar si el jugador presiona la tecla de salto y está en el suelo
        if (Input.GetButtonDown("Jump") && enSuelo)
        {
            // Aplicar una fuerza hacia arriba para simular el salto
            fisicas.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

            // Cambiar la variable enSuelo a false para evitar múltiples saltos en el aire
            enSuelo = false;
        }
    }

    // Este método se llama cuando el objeto colisiona con otro objeto activando un efecto
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si la colisión es con un objeto etiquetado como "llave" y destruir ambos objetos
        if (other.gameObject.CompareTag("llave")) //llave negra 
        {
            GameObject obstaculo = GameObject.FindGameObjectWithTag("obstaculo");//buscas un objeto con la tag obstaculo
            Destroy(obstaculo);//destrulles el objeto encontrado
            Destroy(other.gameObject);//destrulles el objeto colisionado
        }
        if (other.gameObject.CompareTag("reduce")) //manzana reductora
        {
            Destroy(other.gameObject);
            transform.localScale /= 2f;// el simbolo /= significa % aqui te reduce la mitad de la proporcion del personaje            

        }
        if (other.gameObject.CompareTag("coin")) //manzanas puntos
        {
            Destroy(other.gameObject);
        }
        if (!other.gameObject.CompareTag("final"))// meta o premio final 
        {
            Destroy(other.gameObject);
        }
    }
}
