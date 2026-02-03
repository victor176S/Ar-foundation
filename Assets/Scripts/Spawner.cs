using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private List<GameObject> spawners;

    private int pattern;

    private int objetoElegido;

    private GameObject objeto;

    [SerializeField] GameObject bola;

    [SerializeField] GameObject bolaAlta;

    [SerializeField] GameObject calaveraOro;

    [SerializeField] GameObject calaveraDiamante;

    GameObject calavera;

    private bool saleCalavera;

    public float contador;

    private float ajusteSpawner;

    private int tipoCalavera;

    private GameObject datos;

    [SerializeField] GameObject Canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        StartCoroutine(RandomPatternSpawn());

        ajusteSpawner = gameObject.transform.position.z;

        datos = GameObject.Find("DatosPersistentes");

        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;

        /*aqui se ajusta la posicion del spawner para que los objetos puedan salir
        a mayor velocidad pero siempre al principio de la cuesta
        */

        if (contador > 1)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, ajusteSpawner + contador/12f);
        }

        //lleva los puntos para luego mostrarlos en la pantalla de muerte

        datos.GetComponent<Datos>().tiempo = contador;

        //Muestra los puntos

        Canvas.transform.GetChild(6).gameObject.GetComponent<TextMeshProUGUI>().text = Mathf.CeilToInt(contador).ToString();

    }

    //esta funcion destruye los objetos despues de un tiempo, ya que se salen del campo de vision

    private IEnumerator DestroyObjects(GameObject objeto)
    {
        yield return new WaitForSeconds(25);

            if (objeto != null)
            {
                Destroy(objeto);
            }
    }

    /* Este sistema de spawn funciona generando diferentes patrones ya creados, en los que se generan
        las rocas y calaveras de manera aleatoria, que va aumentando la dificultad con el tiempo*/

    private IEnumerator RandomPatternSpawn()
    {   
        while (true)
        {

            //cuanto más tiempo pase, más rapido salen las rocas

            yield return new WaitForSeconds(2 - contador/2000);

            //aqui se determinan los tipos de rocas y calaveras

            pattern = UnityEngine.Random.Range(0,6);

            objetoElegido = UnityEngine.Random.Range(0,2);

            saleCalavera = Convert.ToBoolean(UnityEngine.Random.Range(0,2));

            tipoCalavera = UnityEngine.Random.Range(0,6);

            //las calaveras de diamante son más raras

            if (tipoCalavera <= 4)
            calavera = calaveraOro;

            else calavera = calaveraDiamante;

            //aqui se asigna el objeto de roca dependiendo de lo que saliese arriba

            switch (objetoElegido)
            {
                case 0:

                    objeto = bola;

                    break;

                case 1:

                    objeto = bolaAlta;

                    break;
            }

        //cada "case" es un patron, siendo spawners[0] la primera columna, [1] la segunda 
        // y [2] la tercera

        switch (pattern)
        {
            case 0:

                Debug.Log("Instanciar");

                /*Primero sale el objeto y (si pasa) la calavera, a ambos se les asigna una velocidad
                dependiendo del tiempo*/

                GameObject bola0 = Instantiate(objeto, spawners[0].transform.position, Quaternion.identity);

                if (saleCalavera)
                {

                    GameObject calavera0 = Instantiate(calavera, spawners[2].transform.position, Quaternion.identity);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                    StartCoroutine(DestroyObjects(calavera0));

                    saleCalavera = false;

                }

                bola0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola0));

                break;

            case 1:

                GameObject bola1 = Instantiate(objeto, spawners[1].transform.position, Quaternion.identity);

                bola1.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola1.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola1));

                if (saleCalavera)
                {

                    GameObject calavera0 = Instantiate(calavera, spawners[2].transform.position, Quaternion.identity);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                    StartCoroutine(DestroyObjects(calavera0));

                    saleCalavera = false;

                }

                break;

            case 2:

                GameObject bola2 = Instantiate(objeto, spawners[2].transform.position, Quaternion.identity);

                bola2.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola2.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola2));

                if (saleCalavera)
                {

                    GameObject calavera0 = Instantiate(calavera, spawners[0].transform.position, Quaternion.identity);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                    StartCoroutine(DestroyObjects(calavera0));

                    saleCalavera = false;

                }

                break;

            case 3:

                GameObject bola3 = Instantiate(objeto, spawners[0].transform.position, Quaternion.identity);

                GameObject bola4 = Instantiate(objeto, spawners[1].transform.position, Quaternion.identity);

                bola3.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola4.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola3.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                bola4.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola3));

                StartCoroutine(DestroyObjects(bola4));

                if (saleCalavera)
                {

                    GameObject calavera0 = Instantiate(calavera, spawners[2].transform.position, Quaternion.identity);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                    StartCoroutine(DestroyObjects(calavera0));

                    saleCalavera = false;

                }

                break;

            case 4:

                GameObject bola5 = Instantiate(objeto, spawners[0].transform.position, Quaternion.identity);

                GameObject bola6 = Instantiate(objeto, spawners[2].transform.position, Quaternion.identity);

                bola5.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola6.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola5.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                bola6.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola5));

                StartCoroutine(DestroyObjects(bola6));

                if (saleCalavera)
                {

                    GameObject calavera0 = Instantiate(calavera, spawners[1].transform.position, Quaternion.identity);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                    StartCoroutine(DestroyObjects(calavera0));

                    saleCalavera = false;

                }

                break;

            case 5:

                GameObject bola7 = Instantiate(objeto, spawners[1].transform.position, Quaternion.identity);

                GameObject bola8 = Instantiate(objeto, spawners[2].transform.position, Quaternion.identity);

                bola7.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola8.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola7.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                bola8.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola7));

                StartCoroutine(DestroyObjects(bola8));

                if (saleCalavera)
                {

                    GameObject calavera0 = Instantiate(calavera, spawners[0].transform.position, Quaternion.identity);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                    calavera0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 2, ForceMode.VelocityChange);

                    StartCoroutine(DestroyObjects(calavera0));

                    saleCalavera = false;

                }

                break;
            }
        }
    }
}
