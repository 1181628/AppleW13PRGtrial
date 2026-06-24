using UnityEngine;
using System.Runtime.InteropServices;

public class PluginTest : MonoBehaviour
{
    [DllImport("MyPlugin")]
    private static extern int AddNumbers(int a, int b);

    void Start()
    {
        Debug.Log(AddNumbers(5, 7));
    }
}
