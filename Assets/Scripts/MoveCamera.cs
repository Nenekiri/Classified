using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

    //variables
    public float speed = 5.0f;
    public Vector3 myCamPos = Vector3.zero;
    public Quaternion myCamRot; 

    void Awake() {

        myCamPos = Camera.main.transform.position;
        myCamRot = Camera.main.transform.rotation; 
        /*
        //gets the camera positions
     float px = Camera.main.transform.position.x;
     float py = Camera.main.transform.position.y;
     float pz = Camera.main.transform.position.z;

    //gets the camera rotations
     float rx = Camera.main.transform.rotation.x;
     float ry = Camera.main.transform.rotation.y;
     float rz = Camera.main.transform.rotation.z;*/


    }//end of Awake method

    // Use this for initialization
    void Start () { 
        
	}

    // Update is called once per frame
    void Update()
    {
        MoveCam();
        ResetCam(); 
    }//end of update method

    void MoveCam()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        
    }//end of move cam method

    void ResetCam()
    {
        if (Input.GetKey(KeyCode.R)) {
            Camera.main.transform.position = myCamPos;
            Camera.main.transform.rotation = myCamRot;  
        }//end of if

    }//end of Reset Cam method

    void OnMouseDrag() {

    }

}
