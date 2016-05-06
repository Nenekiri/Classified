using UnityEngine;
using System.Collections;

public class DishCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown() {
        
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            Globals.dishCursor = true;
            Globals.flashCursor = false;
       


    }//end of OnMouseDown
}
