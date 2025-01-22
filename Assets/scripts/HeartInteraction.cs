using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartInteraction : MonoBehaviour
{
    public GameObject heartPrefab; // Reference to the heart prefab

    void Start()
    {
        // Optionally find the heart prefab dynamically if not assigned
        if (heartPrefab == null)
        {
            heartPrefab = GameObject.Find("HeartSphere");
        }
    }

    void OnMouseDown()
    {
        // Action when the sphere is clicked
        if (heartPrefab != null)
        {
            Debug.Log("Heart clicked!");
            // Add your custom functionality here
            // For example: Display a UI panel with heart info
        }
        else
        {
            Debug.LogWarning("Heart prefab is not assigned!");
        }
    }
}