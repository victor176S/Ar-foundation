using TMPro;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceJumpController : MonoBehaviour
{
    public ARFace face;
    public Rigidbody playerRb;
    public PlayerJump player;

    [Header("Jump Settings")]
    public float jumpForce = 14f;
    public float pitchJump = 20f;
    public float cooldown = 0.8f;

    private bool isGrounded = true;
    private float lastJumpTime;

    [SerializeField] private TextMeshProUGUI debug;

    void Update()
    {
        

        if (face == null || playerRb == null) return;

        Vector3 rotation = face.transform.localEulerAngles;
        float pitch = rotation.x;
        debug.text = pitch.ToString();

        if (pitch > 180) pitch -= 360;

        if (pitch > pitchJump && player.isGrounded && Time.time - lastJumpTime > cooldown)
        {
            

            Jump();
        }
    }

    void Jump()
    {
        playerRb.linearVelocity = new Vector3(playerRb.linearVelocity.x, 0, playerRb.linearVelocity.z);
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        player.isGrounded = false;
        lastJumpTime = Time.time;
    }



 
}
