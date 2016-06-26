using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

    // Use this for initialization

    public GameObject objects;
    public string nameTrigger;
    public AudioClip audioOpen;
    public AudioClip audioClose;
    public float posX;
    public float posY;
    public float posZ;
    public float traY;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private bool flag = false;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider collider)
    {

        if (collider.name.Equals(nameTrigger))
        {

            if (Input.GetKeyDown("q"))
            {
                objects.transform.localPosition = new Vector3(posX, posY, posZ);
                objects.transform.localRotation = Quaternion.Euler(0, traY, 0);
                gameObject.AddComponent<AudioSource>();
                source.clip = audioOpen;
                source.playOnAwake = false;
                source.PlayOneShot(audioOpen);
                flag = true;

            }
        }
    }
        void OnTriggerEnter(Collider collider)
    {

            if (collider.name.Equals(nameTrigger))
            {

                if (flag)
                {
                    objects.transform.localPosition = new Vector3(0, 0, 0);
                    objects.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    gameObject.AddComponent<AudioSource>();
                    source.clip = audioClose;
                    source.playOnAwake = false;
                    source.PlayOneShot(audioClose);
                    flag = false;

                }
            }

        }
}
