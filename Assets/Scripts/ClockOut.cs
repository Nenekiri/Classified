using UnityEngine;
using System.Collections;

public class ClockOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //checks for a left click by the player
    void OnMouseDown() {
        if (Globals.flashCursor == true)
        {   //check for which level to load
            if (Application.loadedLevelName == "TestPicture")
            {
                Application.LoadLevel(2);
            }
        }//end of first if statement
    }

}//end of class
