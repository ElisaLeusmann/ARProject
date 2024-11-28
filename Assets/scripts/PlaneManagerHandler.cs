using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARObjectManager : MonoBehaviour
{
    public ARPlaneManager arPlaneManager;  // Reference to the ARPlaneManager
    //public GameObject objectPrefab;        // The prefab to spawn
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
    }

    // Call this method when an object is placed
    public void OnObjectPlaced(ARObjectPlacementEventArgs args)
    {
        if (objectPlaced)
            return;  // If object already placed, do nothing

        objectPlaced = true;

        // Spawn the object at the AR hit point (you could get this from your Raycast manager or touch input)
        Vector3 spawnPosition = new Vector3(0, 0, 0); // Example position, replace with your logic
        //Instantiate(objectPrefab, spawnPosition, Quaternion.identity);


        // Disable plane detection
        DisablePlaneDetection();
        placementInteractable.placementPrefab = null;

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

        // Optionally: You can also stop the ARRaycastManager from detecting new planes as well
        // For example, if you're using it for interaction with the spawned object.
        //arRaycastManager.enabled = false; // Disables raycasting
    }

}
