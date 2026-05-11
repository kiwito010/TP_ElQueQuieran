using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MovimientoCajas : MonoBehaviour
{
    private Vector3 posicionInicial = new Vector3(0, 0, 0);
    public TextMeshProUGUI txt_Score;
    private int Score=0;
    private float Tiempo=0f;
    void Update()
    {
       
        ManejarMovimiento();

       
        Tiempo += Time.deltaTime;
        if (Tiempo >= 1f)
        {
            Score++;
            txt_Score.text = "Puntos: " + Score;
            Tiempo = 0f;
        }
    }

    void ManejarMovimiento()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.Translate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Translate(2, 0, 0);
        }
        if (transform.position.x >= 4) transform.position = new Vector3(2, 0.5f, 0);
        if (transform.position.x <= -4) transform.position = new Vector3(-2, 0.5f, 0);
    }
}