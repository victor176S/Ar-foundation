using System.Collections;
using TMPro;
using UnityEngine;

public class Eventosprincipio : MonoBehaviour
{

    [SerializeField] private float contador;

    [SerializeField] private GameObject texto;

    [SerializeField] private GameObject flecha;
    [SerializeField] private float tiempoOut;

    [SerializeField] private float tiempoIn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Eventos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //las animaciones del tutorial

    IEnumerator Eventos()
    {
        yield return new WaitForSeconds(3);

        //se quita el texto y la flecha se va hacia la izq, además se gira en la direccion de la derecha

        texto.GetComponent<TextMeshProUGUI>().text = "";

        for (int i = 0; i < 300; i++)
        {

            texto.transform.position += new Vector3(-2.5f,0,0);

            flecha.transform.position += new Vector3(-2.5f,0,0);

            flecha.transform.localRotation = Quaternion.Euler(0, 0, flecha.transform.localEulerAngles.z + 0.3f);

            yield return new WaitForSecondsRealtime(0.003f);
        }

        //la flecha se va de izq a derecha y se pone el texto que explica el movimiento con la animacion de la flecha

        texto.GetComponent<TextMeshProUGUI>().text = "Debes moverte moviendo tu cabeza a los lados";

        for (int i = 0; i < 600; i++)
        {

            texto.transform.position += new Vector3(2.5f,0,0);

            flecha.transform.position += new Vector3(2.5f,0,0);

            yield return new WaitForSecondsRealtime(0.002f);
        }

        for (int i = 0; i < 300; i++)
        {

        flecha.transform.localRotation = Quaternion.Euler(0, 0, flecha.transform.localEulerAngles.z + 0.6f);

        yield return new WaitForSecondsRealtime(0.001f);

        }

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 300; i++)
        {

            texto.transform.position += new Vector3(-2.5f,0,0);

            flecha.transform.position += new Vector3(-2.5f,0,0);

            yield return new WaitForSecondsRealtime(0.002f);
        }

        texto.GetComponent<TextMeshProUGUI>().text = "";

        yield return new WaitForSeconds(0.5f);

        //se pone un texto junto con una animacion de la flecha que va de arriba a abajo, que explica como saltar

        texto.GetComponent<TextMeshProUGUI>().text = "Tambien puedes saltar si miras hacia arriba";

        for (int i = 0; i < 200; i++)
        {
            flecha.transform.localRotation = Quaternion.Euler(0, 0, flecha.transform.localEulerAngles.z - 0.45f);

            texto.transform.position += new Vector3(0f,1,0);

            flecha.transform.position += new Vector3(0f,1,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        for (int i = 0; i < 200; i++)
        {

            texto.transform.position += new Vector3(0f,-1,0);

            flecha.transform.position += new Vector3(0f,-1,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        for (int i = 0; i < 200; i++)
        {

            texto.transform.position += new Vector3(0f,1,0);

            flecha.transform.position += new Vector3(0f,1,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        for (int i = 0; i < 200; i++)
        {

            texto.transform.position += new Vector3(0f,-1,0);

            flecha.transform.position += new Vector3(0f,-1,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        for (int i = 0; i < 200; i++)
        {

            texto.transform.position += new Vector3(0f,1,0);

            flecha.transform.position += new Vector3(0f,1,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        for (int i = 0; i < 200; i++)
        {

            flecha.transform.localRotation = Quaternion.Euler(0, 0, flecha.transform.localEulerAngles.z + 0.9f);

            texto.transform.position += new Vector3(0f,-1,0);

            flecha.transform.position += new Vector3(0f,-1,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        yield return new WaitForSeconds(1f);

        texto.GetComponent<TextMeshProUGUI>().text = "";

        for (int i = 0; i < 200; i++)
        {

            texto.transform.position += new Vector3(2.5f,0,0);

            flecha.transform.position += new Vector3(2.5f,0,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

        //la flecha se aparta y explica como funcionan las calaveras, luego el texto y la flecha se van

        yield return new WaitForSeconds(0.5f);

        texto.GetComponent<TextMeshProUGUI>().text = "Las calaveras aumentan tu puntuacion pero hacen el juego más dificil";

        yield return new WaitForSeconds(2);

        for (int i = 0; i < 200; i++)
        {

            texto.transform.position += new Vector3(0f,-10,0);

            flecha.transform.position += new Vector3(0f,-10,0);

            yield return new WaitForSecondsRealtime(0.0005f);
        }

    }
}
