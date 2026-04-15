using UnityEngine;

public class pj: MonoBehaviour
{

     public Vector3 inicioPersonaje=new Vector3(1,1,0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    this.transform.position = inicioPersonaje;
        }

    // Update is called once per frame
    void Update()
    {
    this.transform.position = new Vector3(this.transform.position.x+0.1f,this.transform.position.y,this.transform.position=inicioPersonaje.z);


        
    }

}
