using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int puntuacionMaxima;
    [SerializeField] int puntuacionminima;
    [SerializeField] float tiempo;
   [SerializeField] public int puntuacionActual = 0;
   [SerializeField] public int mejorPuntuacion = 0;
    [SerializeField] GameObject guardarText, guardarBoton, guardarJugador, guardarEnemigo;
    [SerializeField] bool Cronometro;
    [SerializeField] enemigo enemigo;
    
    public static GameManager instancia;
   
    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        guardarText.SetActive(false);
        guardarBoton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Cronometro == true)
        {
            tiempo += Time.deltaTime;
             int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
           //  = minutos.ToString("D2") + "." + segundos.ToString("D2");
        }
    }

    void perder()
    {
        guardarJugador.SetActive(false);
        guardarEnemigo.SetActive(false);
        guardarText.SetActive(true);
        guardarBoton.SetActive(true);
        Cronometro = false;
    }

    void Reiniciarjuego()
    {
        puntuacionActual = 0;
        guardarJugador.SetActive(true);
        guardarEnemigo.SetActive(true);
        guardarText.SetActive(true);
        guardarBoton.SetActive(true);
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
