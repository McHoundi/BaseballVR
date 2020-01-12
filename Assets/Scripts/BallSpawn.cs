using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{

    public GameObject baseballPrefab;
    private int throwSpeed = 10;
    [SerializeField] GameObject ballCannon;
    private Vector3 cannonDirection;
    GameObject newBall;
    Rigidbody ballRB;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update cannon's forward direction
        cannonDirection = ballCannon.transform.forward;

        //if button is pressed, spawn and throw a ball
        if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.C) )
        {
            SpawnBall();
            ThrowBall();
        }
    }

    void SpawnBall()
    {
        newBall = Instantiate(baseballPrefab, transform);
        ballRB = newBall.GetComponent<Rigidbody>();
    }

    //throws ball along cannon's forward (z) axis with throwSpeed
    void ThrowBall()
    {
        ballRB.velocity = cannonDirection * throwSpeed;
    }
}
    