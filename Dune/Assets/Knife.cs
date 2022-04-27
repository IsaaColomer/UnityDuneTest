using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public bool readyToKnife;
    public LineRenderer lr;
    public static Knife instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if(!readyToKnife)
            {
                readyToKnife = true;
                Stone.instance.readyToThrow = false;
            }
            else
            {
                readyToKnife = false;
            }
        }
        if(readyToKnife)
        {
            
            RaycastHit hit1;
            Ray ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
            lr.SetPosition(0, transform.position);
            if(Physics.Raycast(ray1, out hit1, Mathf.Infinity))
            {
                lr.SetPosition(1, hit1.point);                    
            }
            
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    if(hit.transform.tag == "Enemy")
                    {
                        Destroy(hit.transform.gameObject);
                    }
                }
            }
        }
    }
}
