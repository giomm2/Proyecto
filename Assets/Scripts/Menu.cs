using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    public Canvas canvas;
    private bool isShowing;
	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas> ();
        canvas.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyUp(KeyCode.Escape)) {
            canvas.enabled = !canvas.enabled;
        }
	}
}
