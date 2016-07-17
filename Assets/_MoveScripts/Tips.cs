using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tips : MonoBehaviour
{

    private int numLevel;
    private string[] tip = { " You can change the camera using C ", " You can open doors using Q ", " If you open some house room, and Damian appear you lose life.", "Else you win life.", " You have to complete all objective ", "If the time is 0, you will return to the last checkpoint ", "OBJECTIVE 1: Find this picture. " };
    public Sprite[] img;
    public Image picture;
    public Text txtTips;
    public GameObject pictureDamian;
    public GameObject Key;
    private int playTime;
    private int time0;
    // Use this for initialization
    void Start()
    {
        Level level = new Level();
        numLevel = level.GetTimers();
        playTime=(int)Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        time0 = ((int)Time.time - playTime);

        if (numLevel == 1)
        {

            if (time0>= 0 && time0< 10)
            {
                txtTips.text = tip[0];
                picture.sprite = img[0];
            }
            else if (time0 == 10)
            {
                txtTips.text = tip[1];
                picture.sprite = img[1];
            }
            else if (time0 == 20)
            {
                txtTips.text = tip[2];
                picture.enabled = false;
            }
            else if (time0 == 30)
            {
                txtTips.text = tip[3];

            }
            else if (time0 == 40)
            {
                txtTips.text = tip[4];

            }
            else if (time0 == 50)
            {
                txtTips.text = tip[5];

            }
            else if (time0 == 60)
            {
                picture.enabled = true;
                txtTips.text = tip[6];
                picture.sprite = img[2];
       
            }




        }
        else if (numLevel != 1)
        {
            txtTips.text = tip[6];
            picture.sprite = img[2];
        }


        if (pictureDamian.active == false && Key.active == true)
        {

            picture.sprite = img[3];
            txtTips.text = " OBJECTIVE 2: Now find the key. ";

        }
        else if (pictureDamian.active == false && Key.active == false) {
            picture.enabled = false;
            txtTips.text = " You try to scape from Damian, and find the front door. ";
        } 

    }
}
