using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testmodesetter : MonoBehaviour
{

    public bool testCameraEnabled;
    public bool debugTextEnabled;
    public GameObject testCamera; //References the TestCamera, used to display the game inside unity, rather than inside VR glasses.
    public GameObject debugText; //References the debugText TextMeshPro-GameObject
    public GameObject playerController;

    // Start is called before the first frame update
    void Start()
    {
        if (testCameraEnabled)
        {
            playerController.SetActive(false);
            testCamera.SetActive(true);
        } else
        {
            playerController.SetActive(true);
            testCamera.SetActive(false);
        }

        if (debugTextEnabled)
        {
            debugText.SetActive(true);
        } else
        {
            debugText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
