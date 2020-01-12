using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmodesetter : MonoBehaviour
{

    public bool testmodeEnabled;
    public GameObject testCamera;
    public GameObject playerController;

    // Start is called before the first frame update
    void Start()
    {
        if (testmodeEnabled)
        {
            playerController.SetActive(false);
            testCamera.SetActive(true);
        } else
        {
            playerController.SetActive(true);
            testCamera.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
