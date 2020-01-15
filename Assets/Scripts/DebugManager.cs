using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DebugManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro debugText;
    
    [SerializeField]
    private Text xAxisBoostSliderText;

    //Sliders
    [SerializeField]
    private Slider xAxisBoostSlider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //velocity info shows the time since the last ball hit, as well as said ball's x, y, and z velocities
    public void setVelocityInfo(float time, float x, float y, float z)
    {
        debugText.SetText("Ballvelocity " + time + "\n" + "X: " + x.ToString("F2") + "\n" + "Y: " + y.ToString("F2") + "\n" + "Z: " + z.ToString("F2"));
    }

    public void setXAxisBoostSliderText()
    {
        xAxisBoostSliderText.text = "X-axis boost: " + xAxisBoostSlider.value.ToString("F2");
    }

}
