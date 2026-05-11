using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMala : MonoBehaviour
{
    public float speed=-3f;
    public float aceleracion=-0.005f;
    public int TextMeshProUGUI;
    int Score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed*Time.deltaTime,0);
        speed=speed+aceleracion;
    }
}