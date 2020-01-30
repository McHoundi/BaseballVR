using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressEventHandler : MonoBehaviour
{

    public GameObject uiCanvas; //References the LeftHand ui canvas placed under left hand anchor in OVRPlayerController
    private bool uiEnabled;
    // Start is called before the first frame update
    void Start()
    {
        //Disabling ui at the start of program
        uiCanvas.SetActive(false);
        uiEnabled = uiCanvas.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Start))
        {
            if ( uiEnabled )
            {
                uiCanvas.SetActive(false);
                uiEnabled = false;
            } else
            {
                uiCanvas.SetActive(true);
                uiEnabled = true;
            }


        }
    }
}
