using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthLifeBar : MonoBehaviour
{
    private Scrollbar HealthBar;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void setHealthLife(Scrollbar barScroll)
    {

        HealthBar = barScroll;

    }

    public Scrollbar getHealthBar()
    {

        return HealthBar;

    }
}
