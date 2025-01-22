using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPopup : MonoBehaviour
{
    public GameObject PopUp; // Assign your popup GameObject in the Inspector

    private void Start()
    {
        // Ensure the popup is initially hidden
        if (PopUp != null)
        {
            PopUp.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Popup is not assigned.");
        }
    }

    private void Update()
    {
        // Handle touch or mouse input
        if (Input.GetMouseButtonDown(0)) // For mouse clicks
        {
            CheckTouch(Input.mousePosition);
        }
        else if (Input.touchCount > 0) // For touch input
        {
            CheckTouch(Input.GetTouch(0).position);
        }
    }

    private void CheckTouch(Vector3 inputPosition)
    {
        // Cast a ray from the camera to the input position
        Ray ray = Camera.main.ScreenPointToRay(inputPosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.transform.CompareTag("Heart")) // Check if the object has the "Heart" tag
            {
                Debug.Log("Heart touched!");
                ShowPopup();
            }
        }
    }

    private void ShowPopup()
    {
        if (PopUp != null)
        {
            PopUp.SetActive(true); // Display the popup
        }
        else
        {
            Debug.LogWarning("Popup UI is not assigned.");
        }
    }

    public void ClosePopup()
    {
        if (PopUp != null)
        {
            PopUp.SetActive(false); // Close the popup
        }
    }
}