using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    private List<GameObject> spawners;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(AsignacionSpawners());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator AsignacionSpawners()
    {
        int i = 0;
        while (this.gameObject.transform.GetChild(i) != null)
        {
            spawners.Add(this.gameObject.transform.GetChild(i).gameObject);

            i++;
        }

        yield return new WaitForSeconds(0.0001f);
    }

    /*private IEnumerator RandomSpawn()
    {

    

        Random.Range(0f,2f); 
    }*/
}
