using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MovementShooting : NetworkBehaviour{

    public Animator animator;
    private float inputH;
    private float inputV;
    public Rigidbody Rbody;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        Rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }


        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        animator.SetFloat("inputH", inputH);
        animator.SetFloat("inputV", inputV);

        float moveX = inputH * 20f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;

        Rbody.velocity = new Vector3(moveX, 0f, moveZ);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }

    }

    [Command]
    void CmdFire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6.0f;
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 2);


    }
}
