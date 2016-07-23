using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Canvas canvas;
    private bool isShowing;
    public GameObject milagro;
    public GameObject camera;
    public GameObject main_camera;

    // Use this for initialization
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        milagro = GameObject.Find("Milagro");
        main_camera = GameObject.Find("Main Camera");
        camera = GameObject.Find("Camera"); //gameObject.GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = !canvas.enabled;
            milagro.GetComponent<Animator>().speed = 0f;
            camera.GetComponent<Camera>().enabled = false;
            //main_camera.GetComponent<MouseLook>.enabled = false;
        }
    }
}