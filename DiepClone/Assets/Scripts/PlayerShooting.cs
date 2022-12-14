using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletTransform;
    [SerializeField] private bool canFire;
    [SerializeField] private float firingCooldown;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canFire)
        {
            canFire= false;
            Instantiate(bullet,bulletTransform.position, Quaternion.identity);
        }
        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > firingCooldown)
            {
                canFire= true;
                timer= 0;
            }
        }
    }
}
