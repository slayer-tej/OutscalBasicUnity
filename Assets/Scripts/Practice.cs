using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice :  MonoBehaviour  
{
    //Awake function is called if the object is created
    private void Awake()
    {
        Debug.Log("Awake function to execute");

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("first function to execute");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Update Input F button is pressed:");

        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Update Input F:");

        }
        if (Input.GetKeyUp(KeyCode.F) || Input.GetMouseButtonUp(0))
        {
            Debug.Log("Update Input F button is Released:");

        }
    }

    //anything related to physics
    private void LateUpdate()
    {
        
    }
}
