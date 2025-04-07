
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Slider Oxygen;
    public Slider Fuel;

    public float o2;
    public bool isOxygen = false;
    public int i = 0;

    private static PlayerController instance;
    public static PlayerController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<PlayerController>();
            }
            return instance;
        }
    }

    public void StartOxygenDecrease()
    {
        StartCoroutine(OxygenDecrease());
    }




    public IEnumerator OxygenDecrease()
    {
        while (isOxygen)
        {
            PlayerDataSO.Oxygen -= 0.01f * i;
            o2 = PlayerDataSO.Oxygen;

            Oxygen.value = PlayerDataSO.Oxygen / 120;
            yield return new WaitForSeconds(2f);
        }

    }

    public void AddI()
    {
        if(i == 0)
        {
            i = 1;
        }
        else if(i == 1)
        {
            i = 2;
        }
    }
    public void DicrI()
    {
        if(i == 1)
        {
            i = 0;
        }
        else if(i == 2)
        {
            i = 1;
        }
    }




}
