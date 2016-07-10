using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tips : MonoBehaviour
{

    private int numLevel;
    private string[] tip = { " YOU CAN CHANGE THE CAMERA USING C ", " YOU CAN OPEN DOORS USING Q ", " IF YOU LOOK THE ENEMY DON'T MOVE OR YOU WILL LOSE LIFE ", " YOU HAVE TIME TO COMPLETE ALL OBJECTIVES ", "IF THE TIME IS 0 YOU RETURN TO THE LAST CHECKPOINT ", "OBJECTIVE 1: FIND THIS PICTURE. " };
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
                picture.enabled = true;
                txtTips.text = tip[5];
                picture.sprite = img[2];
       
            }




        }
        else if (numLevel != 1)
        {
            txtTips.text = tip[5];
            picture.sprite = img[2];
        }


        if (pictureDamian.active == false && Key.active == true)
        {

            picture.sprite = img[3];
            txtTips.text = " OBJECTIVE 2: NOW FIND THE KEY. ";

        }
        else if (pictureDamian.active == false && Key.active == false) {
            picture.enabled = false;
            txtTips.text = " ESCAPE TO DAMIAN, FIND THE PRINCIPAL DOOR. ";
        } 

    }
}
