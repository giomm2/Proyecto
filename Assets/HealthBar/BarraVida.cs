using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraVida : MonoBehaviour
{

    public Scrollbar HealthBar;
    public float Health = 100;
    public void Damage(float value)
    {
        Health -= value;
        HealthBar.size = Health / 100f;
    }
    public void Life(float value)
    {
        Health += value;
        HealthBar.size = Health / 100f;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Milagro");
        Damage(50);
       
    }

    
}
    