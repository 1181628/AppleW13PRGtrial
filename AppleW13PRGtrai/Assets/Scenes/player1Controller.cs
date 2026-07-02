using UnityEngine;
using System.Runtime.InteropServices;

public class player1Controller : MonoBehaviour
{
    [DllImport("MyPlugin")]
    private static extern void MovePlayer(float horizontalInput, float speed, float deltaTime, out float outX, out float outY);

    public float runSpeed = 5f;

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float newX, newY;

        // C++ does all the work and gives us back the new X and Y coordinates
        MovePlayer(hInput, runSpeed, Time.deltaTime, out newX, out newY);

        // Update the position in Unity
        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}