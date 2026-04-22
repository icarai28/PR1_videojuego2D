using UnityEngine;

public class coinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {if (col.gameObject.name == "personaje")
    {
        gameObject.GetComponent<Animator>().SetBool("obtenerCoin",true);
        Destroy(this.gameObject,3.0f);
    }
    
    }
}
