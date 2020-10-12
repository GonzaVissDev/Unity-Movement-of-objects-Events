using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 I;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        I = rb.transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
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
