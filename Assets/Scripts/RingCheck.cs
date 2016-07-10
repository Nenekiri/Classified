using UnityEngine;
using System.Collections;

public class RingCheck : MonoBehaviour {

    public Texture2D cursorTexture;
    public Texture2D defTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Globals.flashCursor == true)
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            Globals.ringCursor = true;
            Globals.flashCursor = false;
        }

    }
}
