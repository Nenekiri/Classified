using UnityEngine;
using System.Collections;

public class BookCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.tookBook == true) {
            this.gameObject.SetActive(false); 
        }
        Debug.Log(Globals.tookBook); 
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
