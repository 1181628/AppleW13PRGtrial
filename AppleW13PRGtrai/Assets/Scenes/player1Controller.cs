using UnityEngine;
using System.Runtime.InteropServices;

public class MainBootstrap : MonoBehaviour
{
    // Link your C++ functions
    [DllImport("MyPlugin")] private static extern void GameStart();
    [DllImport("MyPlugin")] private static extern void GameUpdate(float deltaTime);

    void Start()
    {
        // Tell C++ your game is starting
        GameStart();
    }

    void Update()
    {
        // Hand the entire frame update loop over to C++
        GameUpdate(Time.deltaTime);
    }
}