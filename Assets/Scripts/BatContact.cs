using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatContact : MonoBehaviour
{
    Rigidbody ballRB;
    private DebugManager debugManager;
    private float exitTime;
    
    private float xAxisBoost = 3;

    //Sliders
    [SerializeField]
    private Slider xAxisBoostSlider;


    // Start is called before the first frame update
    void Start()
    {
        debugManager = FindObjectOfType<DebugManager>();
    }

    void Update()
    {
        if (ballRB != null)
        {
            exitTime += Time.deltaTime;
            debugManager.setVelocityInfo(exitTime, ballRB.velocity.x, ballRB.velocity.y, ballRB.velocity.z);
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        // only do something if colliding with a baseball (layer 11)
        if ( collision.gameObject.layer == 11 )
        {
            exitTime = 0.0f;
            ballRB = collision.gameObject.GetComponent<Rigidbody>();
            
            if ( ballRB.velocity.y > 0 )
            {
                // give the ball some power to the x direction (toward goals)
                ballRB.velocity.Set(ballRB.velocity.x * xAxisBoost, ballRB.velocity.y, ballRB.velocity.z);
                
            }
        } 
    }

    public void SetXAxisBoost()
    {
        xAxisBoost = xAxisBoostSlider.value;
    }
}
