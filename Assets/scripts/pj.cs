using UnityEngine;

public class pj: MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hola");
    }



    int Sumar(int num1, int num2)
    {
        
        int Suma=num1+num2;

        return Suma;

    }
}
