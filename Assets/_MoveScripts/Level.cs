using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Level : MonoBehaviour
{

    public static int setTime;
    public GameObject btnEasy;
    public GameObject btnMedium;
    public GameObject btnHard;
    public Button btnSingle;
    public Text txtSingle;
    void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }


    public void VisibleButtons(int num)
    {


        if (num == 0)
        {
            btnEasy.SetActive(true);
            btnMedium.SetActive(true);
            btnHard.SetActive(true);

            txtSingle.color = Color.red;
            btnSingle.image.rectTransform.sizeDelta = new Vector2(200, 40);
        }
        else
        {
            btnEasy.SetActive(false);
            btnMedium.SetActive(false);
            btnHard.SetActive(false);
        }
    }
    public void LevelEasy()
    {


        setTime = 1;
        Application.LoadLevel("Scene");



    }
    public void LevelMedium()
    {

        setTime = 2;
        Application.LoadLevel("Scene");

    }
    public void LevelHard()
    {

        setTime = 3;
        Application.LoadLevel("Scene");

    }


    public int GetTimers()
    {

        return setTime;
    }

    public int getPlayTime() {

        return (int)Time.time;
    }
}
