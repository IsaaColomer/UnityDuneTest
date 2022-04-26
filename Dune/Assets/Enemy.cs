using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    private bool goToStone;
    private Transform goToPosition;
    // Start is called before the first frame update
    void Start()
    {
        goToStone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(goToStone)
        {
            agent.SetDestination(goToPosition.position);
        }
        else
        {
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if(other.transform.tag == "Stone")
            {
                goToStone = true;
                goToPosition = other.transform;
            }
        }
        else
        {
            goToStone = false;
        }
    }
}
