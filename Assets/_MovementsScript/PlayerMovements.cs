using UnityEngine;
using System.Collections;

public class PlayerMovements : MonoBehaviour {

	public Animator animator;
	private float inputH;
	private float inputV;
	public Rigidbody Rbody;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		Rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		inputH = Input.GetAxis("Horizontal");
		inputV = Input.GetAxis("Vertical");
		animator.SetFloat("inputH", inputH);
		animator.SetFloat("inputV", inputV);

		float moveX = inputH *20f *Time.deltaTime;
		float moveZ = inputV *50f *Time.deltaTime;

		Rbody.velocity = new Vector3(moveX, 0f, moveZ);

	}
}
