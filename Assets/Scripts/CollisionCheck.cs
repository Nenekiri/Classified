using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    //audio assets
    public AudioClip surprise;
    public AudioClip growl; 
    public AudioSource source;

    //creating and finding the clock gameobject to end the level
    public GameObject clock;

    private tk2dSpriteAnimator anim;

    private bool animSwitch = false;


    // Use this for initialization
    void Start () {

        clock = GameObject.Find("SimpleClock");
        clock.SetActive(false); 
        anim = GetComponent<tk2dSpriteAnimator>();

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

        }

        if (Dialoguer.GetGlobalFloat(0) == 0f && Globals.lastCheck1 == true)
        {
            clock.SetActive(true); 
        }

        

        if (Dialoguer.GetGlobalBoolean(3) == true && animSwitch == false) {
            anim.Play("test2");
        }

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
            anim.Play("Prisoner Surprise"); 

            
        }
        if (Globals.chamberCursor == true && Dialoguer.GetGlobalBoolean(2) == false) {
            Dialoguer.StartDialogue(3);

           
        }


        if (Dialoguer.GetGlobalFloat(0) == 0f)
        {
            Dialoguer.StartDialogue(5);
            Globals.lastCheck1 = true; 

        }//normal ending to the first day. Introduces the player to the clock if they haven't clicked on it yet.

        if (Dialoguer.GetGlobalFloat(0) == 0f && Dialoguer.GetGlobalBoolean(4) == true) {
            animSwitch = true;
            Globals.lastCheck1 = true;
            Dialoguer.StartDialogue(6);
            source.PlayOneShot(growl, 0.5f); 
            anim.Play("PrisonerGrowl1");

        }//dialogue that appears if the player has decided to take the book from the prisoner. 

    }//end of OnMouseDown


    
}//end of class
