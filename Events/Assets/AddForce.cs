using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float Force = 150f;
    private Rigidbody2D Rg2d;
    private Vector2 I;
    // Start is called before the first frame update
    void Start()
    {
        Rg2d = GetComponent<Rigidbody2D>();
        I = Rg2d.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Rg2d.AddForce(transform.up * Force);
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
