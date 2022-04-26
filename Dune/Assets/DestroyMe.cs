using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public float lifeTime = 3f;
    private float lifeTime1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTime>0f)
        {
            lifeTime-=Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
