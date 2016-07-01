using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CargarPartida : MonoBehaviour {
    public static bool loading;
    public Button button;
    

    public void load() {
        
            Application.LoadLevel(1);
            loading = true;
       
    }
    public void noLoad() {
        loading = false;
        Application.LoadLevel(1);
    }
	// Use this for initialization
	void Start () {

        button.interactable = PlayerPrefs.HasKey("Player z");/*PlayerPrefs.GetFloat("Player x") == null && PlayerPrefs.GetFloat("Player y") == null*/;
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
