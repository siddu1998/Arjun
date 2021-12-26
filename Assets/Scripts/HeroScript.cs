using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    Rigidbody rb;

    public GameObject astra;
    public GameObject astra_1;
    public GameObject astra_2;

    public float astra_count   = 10;
    public float astra_1_count = 10;
    public float astra_2_count = 10;

    public GameObject astra_count_text;
    public GameObject astra_1_count_text;


    public Transform bulletPos;

    void Awake() {
        rb = GetComponent<Rigidbody>();    
    }
    // Start is called before the first frame update
    void Start()
    {
       astra_count_text.GetComponent<UnityEngine.UI.Text>().text = astra_count.ToString();
       astra_1_count_text.GetComponent<UnityEngine.UI.Text>().text = astra_1_count.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        astra_count_text.GetComponent<UnityEngine.UI.Text>().text = astra_count.ToString();                
        astra_1_count_text.GetComponent<UnityEngine.UI.Text>().text = astra_1_count.ToString();

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
            this.transform.Rotate(Vector3.up*Time.deltaTime, -1);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up*Time.deltaTime, 1);  
        } 
     if (Input.GetKeyDown(KeyCode.A))
        {
            if(astra_count>0)
            {
                astra_count=astra_count-1;
                GameObject spawned_astra = Instantiate(astra, bulletPos.position, bulletPos.transform.rotation);
                spawned_astra.GetComponent<Rigidbody>().AddForce(bulletPos.forward*200);
                Destroy (spawned_astra, 5.0f);

            }
            else{
                Debug.Log("Out of BramhaAstra");
            }            

        } 
    if (Input.GetKeyDown(KeyCode.S))
        {
            if(astra_1_count>0){
            astra_1_count=astra_1_count-1;
            GameObject spawned_astra_1 = Instantiate(astra_1, bulletPos.position, bulletPos.transform.rotation);
            spawned_astra_1.GetComponent<Rigidbody>().AddForce(bulletPos.forward*500);
            Destroy (spawned_astra_1, 5.0f);
            }
            else{
                Debug.Log("Out of Agni Astra");
            }
        } 
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="astra_refill"){
            astra_count+=10;
            Debug.Log("Astra Refill!");
            Destroy(other.gameObject);

        }
        if(other.gameObject.tag=="astra_1_refill"){
            astra_1_count+=10;
            Debug.Log("Astra 1 Refill!");
            Destroy(other.gameObject);

        }

    }
}
