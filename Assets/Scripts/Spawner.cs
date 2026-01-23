using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private List<GameObject> spawners;

    private int pattern;

    [SerializeField] GameObject bola;

    public float contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //StartCoroutine(AsignacionSpawners());

        StartCoroutine(RandomPatternSpawn());

        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
    }

    private IEnumerator DestroyObjects(GameObject objeto)
    {
        yield return new WaitForSeconds(10);

            if (objeto != null)
            {
                Destroy(objeto);
            }
    }

    private IEnumerator RandomPatternSpawn()
    {   
        while (true)
        {
            yield return new WaitForSeconds(2);

            pattern = Random.Range(0,6);

            

        switch (pattern)
        {
            case 0:

                Debug.Log("Instanciar");

                GameObject bola0 = Instantiate(bola, spawners[0].transform.position, Quaternion.identity);

                bola0.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola0.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 3, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola0));

                break;

            case 1:

                GameObject bola1 = Instantiate(bola, spawners[1].transform.position, Quaternion.identity);

                bola1.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola1.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 3, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola1));

                break;

            case 2:

                GameObject bola2 = Instantiate(bola, spawners[2].transform.position, Quaternion.identity);

                bola2.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola2.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 3, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola2));

                break;

            case 3:

                GameObject bola3 = Instantiate(bola, spawners[0].transform.position, Quaternion.identity);

                GameObject bola4 = Instantiate(bola, spawners[1].transform.position, Quaternion.identity);

                bola3.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola4.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 3, ForceMode.VelocityChange);

                bola3.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 5, ForceMode.VelocityChange);

                bola4.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 3, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola3));

                StartCoroutine(DestroyObjects(bola4));

                break;

            case 4:

                GameObject bola5 = Instantiate(bola, spawners[0].transform.position, Quaternion.identity);

                GameObject bola6 = Instantiate(bola, spawners[2].transform.position, Quaternion.identity);

                bola5.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola6.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 3, ForceMode.VelocityChange);

                bola5.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 5, ForceMode.VelocityChange);

                bola6.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 3, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola5));

                StartCoroutine(DestroyObjects(bola6));

                break;

            case 5:

                GameObject bola7 = Instantiate(bola, spawners[1].transform.position, Quaternion.identity);

                GameObject bola8 = Instantiate(bola, spawners[2].transform.position, Quaternion.identity);

                bola7.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 5, ForceMode.VelocityChange);

                bola8.GetComponent<Rigidbody>().AddForce(Vector3.back * contador / 3, ForceMode.VelocityChange);

                bola7.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 5, ForceMode.VelocityChange);

                bola8.GetComponent<Rigidbody>().AddForce(Vector3.down * contador / 3, ForceMode.VelocityChange);

                StartCoroutine(DestroyObjects(bola7));

                StartCoroutine(DestroyObjects(bola8));

                break;
            }
        }
    }
}
