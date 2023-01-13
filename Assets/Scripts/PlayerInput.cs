using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed = 20;
    [SerializeField] private float _rotateSpeed = 4;
    
    

    // Update is called once per frame
    public void FixedUpdate()
    {
        var distance = Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition+=transform.forward*distance;
        } 
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition -= transform.forward * distance;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-_rotateSpeed,0,Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,_rotateSpeed,0,Space.Self);
        }
        
    }
}
