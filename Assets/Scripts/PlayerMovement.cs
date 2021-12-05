using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rigidbody;
    private float horizontalInput;
    public float horizontalMultplier = 2;
    bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
    }
    void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultplier;

        rigidbody.MovePosition(rigidbody.position + forwardMove + horizontalMove);
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            Die();
        }
        horizontalInput = Input.GetAxis("Horizontal");
    }
    public void Die()
    {
        alive = false;
        Invoke("Restart", 2);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
