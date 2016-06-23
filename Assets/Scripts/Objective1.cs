using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Objective1 : MonoBehaviour {
    public GameObject picture;
    private void OnTriggerEnter(Collider other) {
        GameObject.Find("Milagro");
        picture.SetActive(false);
        SendMessage("Ready Clue");
    }
}
