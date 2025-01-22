using UnityEngine;

public class TouchDetector : MonoBehaviour
{
    void Update()
    {
        // Check for touch or mouse input Input.touchCount > 0
        if (Input.touchCount > 0) // Change to for touch input
        {
            // Get the touch/click position
            Vector3 touchPosition = Input.GetTouch(0).position; // Use Input.GetTouch(0).position for touch
            Ray ray = Camera.main.ScreenPointToRay(touchPosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Check if the hit object is a child of the prefab
                Transform hitTransform = hit.transform;
                Debug.Log("touch recognized");

                if (hitTransform != null)
                {
                    // Display the name of the touched child
                    Debug.Log($"Touched: {hitTransform.name}");
                }
            }
        }
    }
}
