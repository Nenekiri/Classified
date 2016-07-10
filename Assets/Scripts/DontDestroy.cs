using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

    //used to keep the object from being destroyed between scenes
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
