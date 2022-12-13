using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0); 
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        direction = new Vector2(xAxis, yAxis).normalized;
        
        rb.velocity = direction * speed * Time.deltaTime;    
    }
}
