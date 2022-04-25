using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float visionRange;
    public float visionAngle;
    public bool alerted;
    void Start()
    {
        alerted = false;
        visionAngle = 40;
        visionRange = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (alerted)
        {
            //Follow the player
            Debug.Log("alerted = true");
            transform.LookAt(player.transform.position);
        }
        else
        {
            //Checking if we can see the player
            if (Vector3.Distance(transform.position, player.transform.position) <= visionRange)
            {
                if(Vector3.Angle(transform.forward, player.transform.position - transform.position) <=visionAngle)
                {
                    alerted = true;
                }
            }

        }
    }
}
