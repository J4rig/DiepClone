using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int health;

    public Slider slider;

    private void Start()
    {
        slider.maxValue = maxHealth;
        health = maxHealth;
    }

    private void Update()
    {
        slider.value = health;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
