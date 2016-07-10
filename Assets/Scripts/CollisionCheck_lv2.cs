using UnityEngine;
using System.Collections;

public class CollisionCheck_lv2 : MonoBehaviour {

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
    void Start()
    {

        clock = GameObject.Find("SimpleClock");
        clock.SetActive(false);
        anim = GetComponent<tk2dSpriteAnimator>();

    }

    // Update is called once per frame
    void Update()
    {

        //check for the mouse clicking on the prisoner

        if (Input.GetMouseButtonDown(1))
        {
            //reset the variables and the cursor
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            Globals.dishCursor2 = false;
            Globals.chamberCursor2 = false;
            Globals.ringCursor = false; 
            Globals.flashCursor = true;

            


        }

        if (Dialoguer.GetGlobalFloat(3) == 0f && Globals.lastCheck2 == true)
        {
            clock.SetActive(true);
        }



        if (Dialoguer.GetGlobalBoolean(9) == true && animSwitch == false)
        {
            anim.Play("test2");
        }

    }//end of update

    void OnMouseDown()
    {

        Dialoguer.StartDialogue(0);

        if (Globals.dishCursor2 == true && Dialoguer.GetGlobalBoolean(7) == false)
        {
            Dialoguer.StartDialogue(8);



        }
        if (Globals.chamberCursor2 == true && Dialoguer.GetGlobalBoolean(9) == false)
        {
            Dialoguer.StartDialogue(9);
            source.PlayOneShot(surprise);
            anim.Play("Prisoner Surprise");

        }

        if (Globals.ringCursor == true && Dialoguer.GetGlobalBoolean(10) == false)
        {
            Dialoguer.StartDialogue(10); 
        }


        if (Dialoguer.GetGlobalFloat(3) == 0f)
        {
            Dialoguer.StartDialogue(11);
            Globals.lastCheck2 = true; 

        }//normal ending to the second day.

        if (Dialoguer.GetGlobalFloat(3) == 0f && Dialoguer.GetGlobalBoolean(11) == true)
        {
            animSwitch = true;
            Globals.lastCheck2 = true; 
            Dialoguer.StartDialogue(12);
            source.PlayOneShot(growl, 0.5f);
            anim.Play("PrisonerGrowl1.5");

        }//dialogue that appears if the player has decided to take the ring from the prisoner. 

    }//end of OnMouseDown
}//end of class
