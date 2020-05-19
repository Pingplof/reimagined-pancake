using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float startWaitTime; 

    public Transform[] moveSpot;
    private int randonSpot;

    void Start()
    {
        waitTime = startWaitTime; 
        randonSpot = Random.Range(0,moveSpot.Length);
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot[randonSpot].position, speed * Time.deltaTime);
        if(Vector3.Distance(transform.position,moveSpot[randonSpot].position)<0.2f)
        {
            if(waitTime <= 0)
            {
                randonSpot = Random.Range(0, moveSpot.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
