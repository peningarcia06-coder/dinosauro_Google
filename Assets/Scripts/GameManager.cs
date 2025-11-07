using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int puntuacionMaxima;
    [SerializeField] int puntuacionminima;
    [SerializeField] float tiempo;
   [SerializeField] public int puntuacionActual = 0;
   [SerializeField] public int mejorPuntuacion = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   

        
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }

    void perder()
    {

    }

    void Reiniciarjuego()
    {

    }

    void Actualizacionpuntuacion()
    {
        puntuacionActual++;
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
        }

        PlayerPrefs.SetInt("MejorPuntuacion", mejorPuntuacion);
    }
}
