using UnityEngine;
using System.Collections;

public class SecondConvo : MonoBehaviour {
    public GameObject lit;

    private bool started = false;

    // Use this for initialization
    void Start()
    {
        Dialoguer.StartDialogue(4);
        lit = GameObject.Find("Point light");
        lit.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {

        if (started == false)
        {
            StartThatDialogue();
        }

        if (Dialoguer.GetGlobalBoolean(5) == true)
        {
            lit.SetActive(true);
        }//end of if statement

    }//end of update

    void StartThatDialogue()
    {
        Dialoguer.StartDialogue(7);
        started = true;

    }
}
