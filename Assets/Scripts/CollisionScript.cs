using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public float damage;
    public GameObject PowerRing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Enemy"){
            GameObject spawned_ring = Instantiate(PowerRing, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
            Destroy (spawned_ring, 3.0f);
        }
    }
}
