using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //check for the mouse clicking on the prisoner

        if (Input.GetMouseButtonDown(1))
        {
            //reset the variables and the cursor
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            Globals.dishCursor = false;
            Globals.runicCursor = false; 
            Globals.flashCursor = true; 


        }
            

    }//end of update

    void OnMouseDown(){

        Dialoguer.StartDialogue(0);

        if (Globals.dishCursor == true) {
            Dialoguer.StartDialogue(1); 
        }
        if (Globals.runicCursor == true) {
            Dialoguer.StartDialogue(2); 
        }

    }//end of OnMouseDown


    
}//end of class
