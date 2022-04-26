using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public bool readyToKnife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            readyToKnife = true;
        }
        if(readyToKnife)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("Clicked");
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    Debug.Log("aa");
                    
                }
            }
        }
    }
}
