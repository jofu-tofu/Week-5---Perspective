using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject10 : MonoBehaviour
{
    //6
    [SerializeField]float moveSpeed;

    [SerializeField] Vector3 moveDirection;

//8
    float totalMoveDistance;
    Vector3 startingLocation;

    // Start is called before the first frame update
    void Start()
    {
       totalMoveDistance = 10f;
       startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       float distanceTraveled = GetDistanceTraveled();

       if (distanceTraveled > totalMoveDistance)
       {
           FlipMoveDirection();
           this.enabled = false;
           //need to stop the script so the door will stop moving after a certain distance
       }

       gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
       moveDirection = -moveDirection;
       startingLocation = gameObject.transform.position;
       //9
    }

    float GetDistanceTraveled()
    {
       return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
