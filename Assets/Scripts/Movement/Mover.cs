using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

   
    // Update is called once per frame
    void Update()
    {
        UpdateAnimator();
    }

    public void MoveTo(Vector3 destination)
    {
        GetComponent<NavMeshAgent>().destination = destination;
    }

    private void UpdateAnimator()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity; //Get global Nav Mesh Velocity
        Vector3 localVelocity = transform.InverseTransformDirection(velocity); //turn global into local
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("Forward Speed", speed);
    }
    
    
    
}
