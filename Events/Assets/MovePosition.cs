using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float Force = 200f;
    private Rigidbody2D rb;
    private Vector3 I;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        I = rb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.MovePosition(transform.position + (transform.up * Time.deltaTime));
        Vector3 newPosition = transform.position + (transform.up * Time.deltaTime * Force);
        rb.MovePosition(newPosition); 
    }
    void OnEnable()
    {
        EventManager.OnClicked += ResetPosition;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= ResetPosition;
    }

    public void ResetPosition()
    {
        this.transform.position = I;
    }
}
