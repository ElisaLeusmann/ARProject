using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartClickHandler : MonoBehaviour
{
    public GameObject PopUp; // Assign the UI Text GameObject here

    void OnMouseDown()
    {
        // Show the text when the heart is clicked
        if (PopUp != null)
        {
            PopUp.SetActive(true);
        }
    }

    void OnMouseEnter()
{
    GetComponent<Renderer>().material.color = Color.red; // Change color to red
}

void OnMouseExit()
{
    GetComponent<Renderer>().material.color = Color.white; // Reset to original color
}
}
