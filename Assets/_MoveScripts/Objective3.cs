using UnityEngine;
using System.Collections;

public class Objective3 : MonoBehaviour
{


    public Transform target;
    public int moveSpeed;
    public int rotationSpeed;
    public int maxdistance;
    private Transform myTransform;
    public GameObject key;
    public GameObject damian;
    //------------------------------------//    

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        
        maxdistance = 2;

    }


    void Update()
    {
        if (key.active==false)
        {
            damian.SetActive(true);
            // Get a direction vector from us to the target
            Vector3 dir = target.position - myTransform.position;

            // Normalize it so that it's a unit direction vector
            dir.Normalize();

            // Move ourselves in that direction
            myTransform.position += dir * moveSpeed * Time.deltaTime;
            myTransform.LookAt(target);
        }
    }
}