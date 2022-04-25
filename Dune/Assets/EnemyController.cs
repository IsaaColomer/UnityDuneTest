using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> enemies = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                enemies[i].GetComponent<EnemyBehaviour>().alerted = false;
            }
        }
    }
}
