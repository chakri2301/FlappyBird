using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;
    public float flapForce = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnJump()
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(flapForce*Vector2.up, ForceMode2D.Impulse);
        //Debug.Log("Jump pressed");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0f;
    }
}
