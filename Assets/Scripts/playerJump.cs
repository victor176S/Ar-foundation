using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    public bool isGrounded = false;
    public int vidas = 3;

    [SerializeField] GameObject canvas;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Toco el suelo");
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            vidas--;
            if (vidas ==0)
                //Time.timeScale = 0f; esto para el tiempo del juego (para TODO)

            Debug.Log("Choco con obstaculo");
        }
    }

    void Update()
    {
        if (vidas == 2)
        {
            canvas.transform.GetChild(2).gameObject.SetActive(false);
        }

        if (vidas == 1)
        {
            canvas.transform.GetChild(1).gameObject.SetActive(false);
        }

        if (vidas == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}

