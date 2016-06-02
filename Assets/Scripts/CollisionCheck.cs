using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    //audio assets
    public AudioClip surprise;
    public AudioSource source;

    //creating and finding the clock gameobject to end the level
    public GameObject clock; 




    // Use this for initialization
    void Start () {

        clock = GameObject.Find("SimpleClock");
        clock.SetActive(false); 
	
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

            clock.SetActive(true); 

        }

        Debug.Log(Dialoguer.GetGlobalFloat(1));
        Debug.Log(Dialoguer.GetGlobalFloat(2)); 

    }//end of update

    void OnMouseDown(){

        Dialoguer.StartDialogue(0);

        if (Globals.dishCursor == true && Dialoguer.GetGlobalBoolean(1) == false) {
            Dialoguer.StartDialogue(1);

            Debug.Log("FirstConvo is currently: " + Dialoguer.GetGlobalFloat(0)); 
            
            
        }
        if (Globals.runicCursor == true && Dialoguer.GetGlobalBoolean(3) == false) {
            Dialoguer.StartDialogue(2);
            source.PlayOneShot(surprise);

            
        }
        if (Globals.chamberCursor == true && Dialoguer.GetGlobalBoolean(2) == false) {
            Dialoguer.StartDialogue(3);

           
        }


        if (Dialoguer.GetGlobalFloat(0) == 0f)
        {
            Dialoguer.StartDialogue(5);  

        }//normal ending to the first day. Introduces the player to the clock if they haven't clicked on it yet.

        if (Dialoguer.GetGlobalFloat(0) == 0f && Dialoguer.GetGlobalBoolean(4) == true) {
            Dialoguer.StartDialogue(6); 

        }//dialogue that appears if the player has decided to take the book from the prisoner. 

    }//end of OnMouseDown


    
}//end of class
