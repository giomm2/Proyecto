using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 80.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 0.3f;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }
    [Command]
    void CmdFire() {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10.0f;
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 2);
        
                
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
