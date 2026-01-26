using TMPro;
using UnityEngine;

public class DatosMuerte : MonoBehaviour
{

    private GameObject datos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        datos = GameObject.Find("DatosPersistentes");

        gameObject.transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>().text = Mathf.CeilToInt(datos.GetComponent<Datos>().tiempo).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
