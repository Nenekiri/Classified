using UnityEngine;
using System.Collections;

public class DishCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public Texture2D cursorTexture2;
    public Texture2D defTexture; 
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public Sprite fullDish; 
     
    

    // Use this for initialization
    void Start() {
       
    }

    // Update is called once per frame
    void Update() {
        if (Dialoguer.GetGlobalBoolean(6) == true)
        {
            SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = fullDish; 
            Cursor.SetCursor(defTexture, hotSpot, cursorMode);
            Globals.dishCursor2 = false;
            Globals.flashCursor = true;
        }

    }

    void OnMouseDown() {
        if (Globals.flashCursor == true)
        {
            if (Application.loadedLevelName == "TestPicture")
            {
                Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
                Globals.dishCursor = true;
                Globals.flashCursor = false;
            }

            if (Application.loadedLevelName == "SecondVisit")
            {
                Cursor.SetCursor(cursorTexture2, hotSpot, cursorMode);
                Globals.dishCursor2 = true;
                Globals.flashCursor = false;
            }
        }


    }//end of OnMouseDown
}
