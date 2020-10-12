using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{

    private Rigidbody2D rgb2d;
    private Vector2 I;

    private void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        I = rgb2d.transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        rgb2d.transform.position += transform.up * Time.deltaTime;
       
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
