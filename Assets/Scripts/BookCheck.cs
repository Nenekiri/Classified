using UnityEngine;
using System.Collections;

public class BookCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public Texture2D defTexture; 
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

  
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Dialoguer.GetGlobalBoolean(4) == true) {
            this.gameObject.SetActive(false);
            Cursor.SetCursor(defTexture, hotSpot, cursorMode);
            Globals.runicCursor = false;
            Globals.flashCursor = true;
        }
        
    }

    void OnMouseDown()
    {
        if (Globals.flashCursor == true)
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            Globals.runicCursor = true;
            Globals.flashCursor = false;
        }
       



    }//end of OnMouseDown
}
