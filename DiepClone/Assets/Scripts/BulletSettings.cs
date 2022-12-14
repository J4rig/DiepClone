using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSettings : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    private Rigidbody2D rb;
    private Transform tr;
    [SerializeField] private float force;
    private Vector3 direction;
    private float time;
    [SerializeField] private float timeToLive;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        rb = GetComponent<Rigidbody2D>();
        tr = GameObject.FindGameObjectWithTag("CenterOfPlayer").GetComponent<Transform>();
        
        direction = mousePos - tr.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= timeToLive)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GameObject().CompareTag("Box"))
        {
            Destroy(gameObject);
        }
    }
}
