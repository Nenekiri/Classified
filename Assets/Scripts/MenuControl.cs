using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeScene(string scene)
    {

        Application.LoadLevel(scene);


    }

    public void GTFO()
    {

        Application.Quit();


    }

}
