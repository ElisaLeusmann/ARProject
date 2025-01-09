using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARObjectManager : MonoBehaviour
{
    public ARPlaneManager arPlaneManager;  // Reference to the ARPlaneManager
    //public GameObject objectPrefab;        // The prefab to spawn
    public Button showBonesButton;     // Referenz zu deinem Button
    //public ARRaycastManager arRaycastManager;
    public ARPlacementInteractable placementInteractable;
    private bool objectPlaced = false;     // Flag to track if object is already placed

    void Start()
    {
        // Ensure ARPlaneManager is assigned if not already in the Inspector
        if (arPlaneManager == null)
        {
            arPlaneManager = FindObjectOfType<ARPlaneManager>();
        }
        placementInteractable.objectPlaced.AddListener(OnObjectPlaced);
        //code for button noch being visible at first

    }

    // This method is called when object is placed
    public void OnObjectPlaced(ARObjectPlacementEventArgs args)
    {
        if (objectPlaced)
            return;  // If object already placed, do nothing

        objectPlaced = true;


        //Vector3 spawnPosition = new Vector3(0, 0, 0); // Example position, replace with your logic
        //Instantiate(objectPrefab, spawnPosition, Quaternion.identity);


        // Disable plane detection
        DisablePlaneDetection();
        placementInteractable.enabled = false;

    }

    // Method to disable plane detection
    private void DisablePlaneDetection()
    {

        // disable visible planes
        foreach (var plane in arPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false);
        }
        // Disable the ARPlaneManager, so no more planes are detected
        arPlaneManager.enabled = false;

        // Optionally, hide existing planes (optional, based on your use case)
        foreach (var plane in arPlaneManager.trackables)
        {
            plane.gameObject.SetActive(false); // Hide the planes
        }


    }



}
