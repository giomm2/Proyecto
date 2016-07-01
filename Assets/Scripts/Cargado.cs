using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cargado : MonoBehaviour {
    public GameObject Player;
    public Button buttonSave;
    public Button buttonDelete;
    public GameObject cube;

   
	// Use this for initialization
	void Start () {
      
        GameObject.FindGameObjectWithTag("Player");
        if (CargarPartida.loading)
        {
            Player.transform.position = new Vector3(PlayerPrefs.GetFloat("Player x"), 0, PlayerPrefs.GetFloat("Player z"));
            buttonSave.interactable = true;
            buttonDelete.interactable = true;
        }
        else
        {
            buttonSave.interactable = false;
            buttonDelete.interactable = false;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        if (cube.activeInHierarchy == false)
        {
            buttonSave.interactable = true;
            buttonDelete.interactable = true;
        }
    }

    public void Save() {
        PlayerPrefs.SetFloat("Player x", Player.transform.position.x);
        PlayerPrefs.SetFloat("Player z", Player.transform.position.z);
        PlayerPrefs.Save();
            

    }

    public void delete() {
        PlayerPrefs.DeleteKey("Player x");
        PlayerPrefs.DeleteKey("Player z");
    }
}
