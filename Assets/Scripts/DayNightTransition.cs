using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class DayNightTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, 03 * Time.deltaTime);
        transform.LookAt(Vector3.zero);
	}
}
=======
public class DayNightTransition : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, 03 * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
>>>>>>> 811852434803ed7281bc06c26b45c83f1ad221b1
