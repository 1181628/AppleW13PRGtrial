using UnityEngine;

public class player1Controller : MonoBehaviour
{
    public float runSpeed;
    private Rigidbody2D myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    void Run()
    {
        float moveDr = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDr * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
    }
}
