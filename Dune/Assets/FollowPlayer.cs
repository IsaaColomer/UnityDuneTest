using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 _cameraOffset;
    [Range(0.01f, 1.0f)]
    public float smooth = 0.5f;
    public float sens;
    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - player.position;
    }

    void Update()
    {
        float x = 0f;
        if(Input.GetKey(KeyCode.LeftAlt))
        {
            Debug.Log("asd");
            x = Input.GetAxis("Mouse X");
            _cameraOffset = transform.position - player.position;
        }
        transform.RotateAround(player.position, Vector3.up, x*sens);
        
        transform.LookAt(player.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = player.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smooth);
    }
}
