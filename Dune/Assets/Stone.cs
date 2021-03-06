using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public GameObject stonePrefab;
    public static Stone instance;
    public bool readyToThrow;
    // Start is called before the first frame update
    void Start()
    {
        readyToThrow = false;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            readyToThrow = true;
            Knife.instance.readyToKnife = false;      
        }
        if(readyToThrow)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("Clicked");
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    Debug.Log("aa");
                    Instantiate(stonePrefab, hit.point, Quaternion.identity);
                }
            }
        }
    }
}
