using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

    //This scripts purpose is going to be to test the way that the new git repository commits from the local system. 
    //Hooray!

    //This script is also going to be used for testing out dialoguer options and styles

    //start up the dialoguer stuff
    void Awake() {
        Dialoguer.Initialize();
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnGUI() {
        /*if (GUI.Button(new Rect(10, 10, 100, 30), "Start!"))
        {

            // The preferred way to start dialogues is with the DialoguerDialogues enum
            // Like so:
            // Dialoguer.StartDialogue(DialoguerDialogues.My_First_Dialogue_Tree);

            // Or you can start it by passing the ID of the dialogue you want to start
            // Like so:
            // Dialoguer.StartDialogue(0);

            // We'll use the ID method for now, in order to avoid any errors when you start creating your own dialogues.
            Dialoguer.StartDialogue(0, dialoguerCallback);
            this.enabled = false; 

            // By default, the DialoguerDialogues enum is automatically updated when you save your dialogues.
            // You can turn this off in the Dialoguer presferences menu.

        }*/
    }//end of OnGUI method

    //callback method
    private void dialoguerCallback()
    {
        this.enabled = true;
    }
}
