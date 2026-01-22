using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool isGrounded;
    public int vidas = 3;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Tocó el suelo");
        }


     

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ontrigger");
        if (other.gameObject.CompareTag("Enemigo"))
        {
            vidas--;
            if (vidas ==0)
                Time.timeScale = 0f;

            Debug.Log("Choco con enemigo");
        }
    }
}

