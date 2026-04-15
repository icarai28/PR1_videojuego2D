using UnityEngine;

public class disparo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool disparo=InputSystem.actions["Attack"].WasPressedThisFrame
        if (disparo)
        {Instantiate (senyal, new Vector3(0,0,0), Quaternion.identity)
        }
    }
}
