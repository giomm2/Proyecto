using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TimeLevel : MonoBehaviour {

    public Text txtTime;
    private int time;
    private int timeStart;
    // Use this for initialization
    void Start()
    {
        Level level = new Level();
        time = level.GetTimers();
        if (time == 1)
        {

            time = 360;

        }

        else if (time == 2)
        {
            time = 240;
        }
        else
        {

            time = 120;
        }


        timeStart = (int)Time.time;
    }

    // Update is called once per frame
    void Update () {

        txtTime.text ="TIME: "+( time - ((int)Time.time- timeStart));

    }
}
