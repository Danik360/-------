using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawn : MonoBehaviour
{
    public float RepeatRate;
    public GameObject[] pipes;
    public float top;
    public float botton;
    public float timeToDestroy;

    void Start()
    {
        InvokeRepeating("GeneratePipe", 2f, RepeatRate);
    }

    void Update()
    {
            
    }

    void GeneratePipe()
    {
        GameObject newPipe = Instantiate(pipes[Random.Range(0, pipes.Length)]);
        newPipe.transform.position = transform.position + new Vector3 (3.21f,Random.Range(top, botton),0);
        Destroy(newPipe, timeToDestroy);
    }
}
