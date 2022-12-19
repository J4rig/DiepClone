using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratoin : MonoBehaviour
{
    [SerializeField] private GameObject[] objects;
    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }
}
