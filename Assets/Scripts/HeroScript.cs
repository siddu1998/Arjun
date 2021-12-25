using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    Rigidbody rb;

    public GameObject astra;
    public GameObject astra_1;
    public GameObject astra_2;


    public Transform bulletPos;

    void Awake() {
        rb = GetComponent<Rigidbody>();    
    }
    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = new Vector3(0,0,speed);
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime*10);  
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime*10);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -10);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 10);  
        } 
     if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject spawned_astra = Instantiate(astra, bulletPos.position, bulletPos.transform.rotation);
            spawned_astra.GetComponent<Rigidbody>().AddForce(bulletPos.forward*100);
            Destroy (spawned_astra, 5.0f);
        } 
    if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject spawned_astra_1 = Instantiate(astra_1, bulletPos.position, bulletPos.transform.rotation);
            spawned_astra_1.GetComponent<Rigidbody>().AddForce(bulletPos.forward*500);
            Destroy (spawned_astra_1, 5.0f);
        } 
        
    }

}
