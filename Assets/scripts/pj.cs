using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class pj: MonoBehaviour

{
public float ImpulsoSalto=5.0f;
    public float velocidad = 0.3f;

    Rigidbody2D rb;
    bool puedoSaltar=false;
    bool estoyAzul=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {



        Vector2 moveInput=InputSystem.actions["Move"].ReadValue<Vector2>();



        this.transform.Translate(moveInput.x*velocidad, 0, 0);

        if(moveInput.x<0)
    {
        this.GetComponent<SpriteRenderer>().flipX=true;
    } else if(moveInput.x>0)
        {
            this.GetComponent<SpriteRenderer>().flipX=false;
            }
   
RaycastHit2D hit= Physics2D.Raycast(transform.position, Vector2.down,0.5f);
Debug.DrawRay(transform.position, Vector2.down*0.5f, Color.red);
if(hit.collider==true)
{puedoSaltar=true;}
else{

puedoSaltar=false;

}

//SALTIO
bool salto=InputSystem.actions["Jump"].WasPressedThisFrame();
if(salto==true && puedoSaltar==true)

{Debug.Log("salto"); 
rb.AddForce(transform.up*ImpulsoSalto,ForceMode2D.Impulse);

}












    }

  //public  void CambiaColor(float ValorSlide);
 // {this.GetComponent<SpriteRenderer>().color= Color.white;
// estoyAzul=false} 
 //else {this.GetComponent<SpriteRenderer>().color= Color.blue;
 //estoyAzul=true}

}
