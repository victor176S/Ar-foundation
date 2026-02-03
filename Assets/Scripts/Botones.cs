using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*estas funciones son de los distintos botones para cargar las escenas correspondientes,
    siendo la primera para ir al menú en la pantalla de muerte, la segunda para empezar
    la partida desde el menú, y la ultima para cerrar la app desde el menú*/

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Empezar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
