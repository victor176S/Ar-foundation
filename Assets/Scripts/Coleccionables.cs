using UnityEngine;

public class Coleccionables : MonoBehaviour
{
    private GameObject spawners;

    [SerializeField] private bool esDeOro;

    [SerializeField] private bool esDeDiamante;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawners == null)
        spawners = GameObject.Find("Spawners");
    }

    /*cuando entran las calaveras en colision con el jugador, la de oro suma 10 puntos
    y la de diamante 20, luego se destruyen*/

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && esDeOro)
        {
            spawners.GetComponent<Spawner>().contador += 10;

            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Player") && esDeDiamante)
        {
            spawners.GetComponent<Spawner>().contador += 20;

            Destroy(this.gameObject);
        }
    }
}
