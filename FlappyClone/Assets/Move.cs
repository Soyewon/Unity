using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform은 Rigidbody랑 다르게 기본 포함되어있어서 가져올 필요 x
        transform.position += Vector3.left*speed*Time.deltaTime; // (-1,0,0) 의미
    }
}
