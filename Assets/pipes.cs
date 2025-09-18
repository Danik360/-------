using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipesMove : MonoBehaviour
{
    public float speed;
    // public GameObject pipes;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
