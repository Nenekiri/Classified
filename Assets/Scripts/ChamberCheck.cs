using UnityEngine;
using System.Collections;

public class ChamberCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public Texture2D defTexture;

    public GameObject dummyPot;
    public GameObject ring; 
    

    // Use this for initialization
    void Start()
    {
        if (Application.loadedLevelName == "SecondVisit")
        {
            ring = GameObject.Find("ring");
            ring.SetActive(false);
            dummyPot = GameObject.Find("Dummy Pot");
            dummyPot.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Dialoguer.GetGlobalBoolean(8) == true)
        {
            this.gameObject.SetActive(false);
            dummyPot.SetActive(true);
            ring.SetActive(true); 
            Cursor.SetCursor(defTexture, hotSpot, cursorMode);
            Globals.chamberCursor2 = false;
            Globals.flashCursor = true;
        }

    }

    void OnMouseDown()
    {
        if (Globals.flashCursor == true)
        {
            if (Application.loadedLevelName == "TestPicture")
            {
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                Globals.chamberCursor = true;
                Globals.flashCursor = false;
            }

            if (Application.loadedLevelName == "SecondVisit")
            {
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                Globals.chamberCursor2 = true;
                Globals.flashCursor = false;
            }
           
        }


    }//end of OnMouseDown
}
