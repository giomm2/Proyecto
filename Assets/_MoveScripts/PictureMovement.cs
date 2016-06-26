using UnityEngine;
using System.Collections;

public class PictureMovement : MonoBehaviour
{

    public float x;
    public float y;
    public float z;
    public float rotation;
    public GameObject objects;
    public string nameTrigger;
    public AudioClip audio;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public int timer;
    private bool Flag = true;

    void OnTriggerEnter(Collider collider)
    {

        if (collider.name.Equals(nameTrigger))
        {

            if ((int)Time.time >= timer && Flag == true)
            {
                objects.transform.localPosition = new Vector3(x, y, z);
                objects.transform.localRotation = Quaternion.Euler(rotation, 0, 0);
                gameObject.AddComponent<AudioSource>();
                source.clip = audio;
                source.playOnAwake = false;
                source.PlayOneShot(audio);
                Flag = false;

            }
        }

    }

}

