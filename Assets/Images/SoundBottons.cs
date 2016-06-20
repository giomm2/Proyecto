using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]

public class SoundBottons : MonoBehaviour {




    public Text []txt;
    public Button[] btn;
    
    private AudioSource source {get { return GetComponent<AudioSource>(); }}

 
void Start()
    {
        
   
      
        
    }
    public void Backtxt(int num)
    {
        
        txt[num].color = Color.white;
        btn[num].image.rectTransform.sizeDelta = new Vector2(160,30);


    }

    public void Changetxt(int num) {

        txt[num].color = Color.red;
        btn[num].image.rectTransform.sizeDelta = new Vector2(200, 40);

    }
    

    public void PlaySound(AudioClip sound) {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        source.PlayOneShot(sound);

    }

}
