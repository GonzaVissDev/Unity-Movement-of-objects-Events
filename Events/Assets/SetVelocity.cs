using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVelocity : MonoBehaviour
{
    public float Force = 150;
    private Vector2 I;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        I = rb.transform.position;
    }

    void Update()
    {
        rb.velocity = transform.up * Time.deltaTime * Force ;
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
