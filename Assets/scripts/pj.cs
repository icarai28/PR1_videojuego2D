using UnityEngine;

public class pj: MonoBehaviour
{

    int miNumero= 5;
    float miNumeroflotante=0.8f;
    string miCadenaDeTexto="holita, soy un texto";



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("inicio");
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
