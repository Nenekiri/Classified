using UnityEngine;
using System.Collections;

public class DialoguerGUI : MonoBehaviour {

    private bool showing;
    private string text;
    private string[] choices; 

    // Use this for initialization
    void Start() {
        Dialoguer.events.onStarted += onStarted;
        Dialoguer.events.onEnded += onEnded;
        Dialoguer.events.onTextPhase += onTextPhase;

    }

    void OnGUI() {
        if (!showing)
            return;

        GUI.Box(new Rect(10, 10, 200, 150), text);


        if (choices == null)
        {
            if (GUI.Button(new Rect(10, 220, 200, 30), "keep going"))
            {
                Dialoguer.ContinueDialogue(0);
            }
        }
        else {
            for (int i = 0; i < choices.Length; i++) {
                if (GUI.Button(new Rect(10, 220 + (40 * i), 200, 30), choices[i])){
                    Dialoguer.ContinueDialogue(i); 
                }
            }
        }
    }

    // Update is called once per frame
    void Update() {

    }

    private void onStarted() {
        showing = true; 
    }

    private void onEnded() {
        showing = false; 
    }

    private void onTextPhase(DialoguerTextData data){
         text = data.text; 
        }

}
