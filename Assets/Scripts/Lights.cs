using UnityEngine;
using System.Collections;

public class Lights : MonoBehaviour {
    public float duration = 1.0F;
    public Color color0 = Color.red;
    public Color color1 = Color.blue;
    public GameObject light;
    // Use this for initialization
    void Start () {
        light.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        light.GetComponent<Light>().color = Color.Lerp(color0, color1, t);
    }
}
