using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class XPManager : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public int XP;
    public int score;

    private int level = 0;
    public int availableLevel = 0;
    [SerializeField] private int[] XPToNextLevel;

    private void Start()
    {
        XPToNextLevel = new int[8];
        XPToNextLevel[0] = 50;
        XPToNextLevel[1] = 100;
        XPToNextLevel[2] = 150;
        XPToNextLevel[3] = 200;
        XPToNextLevel[4] = 500;
        XPToNextLevel[5] = 700;
        XPToNextLevel[6] = 1000;
        XPToNextLevel[7] = 1500;

        slider.value = 0;
        slider.maxValue = XPToNextLevel[0];
    }

    void Update()
    {
        slider.value = XP;
        if (XP >= XPToNextLevel[level])
        {    
            if (level < 7)
            {
                XP -= XPToNextLevel[level];
                level++;
                availableLevel++;
                slider.maxValue = XPToNextLevel[level];
            }
        }
    }
}
