using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    //audio assets
    public AudioClip surprise;
    public AudioSource source;



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
            Globals.chamberCursor = false;
            Globals.flashCursor = true;

            //Dialoguer.StartDialogue(4); 


        }

        if (Dialoguer.GetGlobalFloat(0) == 0f) {

            Application.LoadLevel(0); 

        }
            

    }//end of update

    void OnMouseDown(){

        Dialoguer.StartDialogue(0);

        if (Globals.dishCursor == true) {
            Dialoguer.StartDialogue(1);
            
            
        }
        if (Globals.runicCursor == true) {
            Dialoguer.StartDialogue(2);
            source.PlayOneShot(surprise);

            
        }
        if (Globals.chamberCursor == true) {
            Dialoguer.StartDialogue(3);

           
        }

    }//end of OnMouseDown


    
}//end of class
