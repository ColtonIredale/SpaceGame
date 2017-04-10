using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMovement : MonoBehaviour {

    public Rigidbody playerRigidBody;
        
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal") *  5.0f;
        float z = Input.GetAxis("Vertical") *  5.0f;

        this.transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 100.0f);
        playerRigidBody.AddRelativeForce(x, 0, z);


        //This way is terrible. Fix ASAP.
        if(Input.GetKeyDown(KeyCode.Q))
        {
            playerRigidBody.drag = 1;
            playerRigidBody.angularDrag = 1;

        }
        else if(Input.GetKeyUp(KeyCode.Q))
        {
            playerRigidBody.drag = 0;
            playerRigidBody.angularDrag = 0;
        }

    }
   
  
} 