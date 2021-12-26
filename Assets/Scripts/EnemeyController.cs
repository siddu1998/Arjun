using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemeyController : MonoBehaviour
{
    public float lookRadius = 10f;
    NavMeshAgent agent;
    Transform target;

    void Awake(){
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;

    }
    // Start is called before the first frame update
    void Start()
    {   
        agent = GetComponent<NavMeshAgent>();
    }
    void FaceTarget()
    {

        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x,0,direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime*5);
    }

    // Update is called once per frame
    void Update()
    {       
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance<=lookRadius)
        {
            agent.SetDestination(target.position);
            if(distance <= agent.stoppingDistance)
                {
                    //attack
                    //face the target
                    FaceTarget();
                }
        }        
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,lookRadius);
    }
}
