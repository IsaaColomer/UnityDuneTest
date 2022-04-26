using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    private bool goToStone;
    private Transform goToPosition;
    public Vector3 startPos;
    public float rotationSpeed = 10f;
    private GameObject stoneGameObject;
    // Start is called before the first frame update
    void Start()
    {
        goToStone = false;
        startPos = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(stoneGameObject != null)
        {
            if(goToStone)
            {
                Vector3 a = new Vector3(goToPosition.position.x, transform.position.y, goToPosition.position.z);
                transform.LookAt(a);                
            }
        }        
        else
        {
            Vector3 b = new Vector3(startPos.x, startPos.y, startPos.z);
            transform.LookAt(b);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // if(other != null)
        // {
        //     stoneGameObject = other.gameObject;
        //     if(other.transform.tag == "Stone")
        //     {
        //         goToStone = true;
        //         goToPosition = other.transform;
        //     }
        // }
        // else
        // {
        //     goToStone = false;
        // }
    }
    void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
            stoneGameObject = other.gameObject;
            if(other.transform.tag == "Stone")
            {
                goToPosition = other.transform;
                goToStone = true;
            }
        }
        else
        {
            goToStone = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Stone")
        {
            stoneGameObject = null;
            goToStone = false;
        }
    }
}
