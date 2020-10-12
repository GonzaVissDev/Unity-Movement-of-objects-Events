using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;



    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 1-100, 5, 100, 30), "Reset"))
        {
            if (OnClicked  != null)
                OnClicked();
        }
    }
   
}
