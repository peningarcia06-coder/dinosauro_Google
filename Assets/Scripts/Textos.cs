using TMPro;
using UnityEngine;

public class Textos : MonoBehaviour
{
    [SerializeField] TMP_Text PuntuacionActual;
    [SerializeField] TMP_Text PuntuacionMaxima;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PuntuacionActual.text = GameManager.instancia.puntuacionActual.ToString();
        PuntuacionMaxima.text = GameManager.instancia.mejorPuntuacion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PuntuacionActual.text = GameManager.instancia.puntuacionActual.ToString();
        PuntuacionMaxima.text = GameManager.instancia.mejorPuntuacion.ToString();
    }
}
