using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class contador : MonoBehaviour
{
    public TMP_Text textoContador;
    private float tiempo = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        textoContador.text = "Inicio cambio :)";
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        //tiempo = tiempo + Time.deltaTime;
        // 0.2s
        // 0.25s
        // 0.5s

        // 0.2 + 0.25 + 0.5 >
        textoContador.text = ((int) tiempo).ToString();
    }
}
