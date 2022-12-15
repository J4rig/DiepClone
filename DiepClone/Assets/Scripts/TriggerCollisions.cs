using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerCollisions : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] string[] tags;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string tag in tags)
        {
            if (collision.GameObject().CompareTag(tag))
            {
                collision.GameObject().GetComponent<Health>().health -= damage;
            }
        }
    }
}
