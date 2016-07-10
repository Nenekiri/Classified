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
            if (Application.loadedLevelName == "TestPicture" && Globals.lastCheck1 == true)
            {
                Application.LoadLevel(2);
            }
            if (Application.loadedLevelName == "SecondVisit")
            {
                if (Dialoguer.GetGlobalFloat(1) >= 2 && Dialoguer.GetGlobalFloat(2) <= 1 && Globals.lastCheck2 == true)
                {
                    Application.LoadLevel("ThirdVisitGood");
                }
                if (Dialoguer.GetGlobalFloat(2) >= 2 && Dialoguer.GetGlobalFloat(1) <= 1 && Globals.lastCheck2 == true)
                {
                    Application.LoadLevel("ThirdVisitBad"); 
                }
            }
            if (Application.loadedLevelName == "ThirdVisitGood")
            {

            }
            if (Application.loadedLevelName == "ThirdVisitBad")
            {

            }
        }//end of first if statement
    }

}//end of class
