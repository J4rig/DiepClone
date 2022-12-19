using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{

    [SerializeField] private Slider slider;

    public int LvL = 0;

    public void LvLUp()
    {
        if (GameObject.FindWithTag("Player").GetComponent<XPManager>().availableLevel > 0)
        {
            LvL++;
            GameObject.FindWithTag("Player").GetComponent<XPManager>().availableLevel--;
        }
    }

    private void Start()
    {
        slider.maxValue = 8;
        slider.value = 0;
    }

    private void Update()
    {
        slider.value = LvL;
    }
}
