using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_moveInput = Input.GetAxisRaw("Horizontal");
        float y_moveInput = Input.GetAxisRaw("Vertical");

        rb.MovePosition (x_moveInput * moveSpeed, y_moveInput * moveSpeed* Time.deltaTime);

    }
}
