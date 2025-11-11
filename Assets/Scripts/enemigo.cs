using System.Collections;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Camera cam;
    [SerializeField] Vector2 posicionInicial, posicionMinima;
    [SerializeField] float velocidad;


    void Start()
    {
        cam = Camera.main;
        posicionMinima = cam.ViewportToWorldPoint(Vector2.zero);
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
            velocidad = velocidad + 0.5f;
        }
    }
   
}
