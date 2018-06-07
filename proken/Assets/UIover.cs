using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIover : MonoBehaviour
{

    public Image gr;

    // Use this for initialization
    void Start()
    {
        gr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void touch()
    {
        gr.enabled = true;
    }
    public void not_touch()
    {
        gr.enabled = false;
    }
}