using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARObjectClickManager : MonoBehaviour
{
    public ARRaycastManager raycastManager;  // Referenz zum ARRaycastManager
    public GameObject prefab;  // Das Prefab, das die Kinder enthält

    private void Update()
    {
        // Überprüfen, ob der Benutzer auf dem Bildschirm klickt oder tippt
        if (Input.touchCount > 0 && raycastManager != null)
        {
            Touch touch = Input.GetTouch(0);

            // Wenn der Benutzer getippt hat
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                // Raycast durchführen, um zu überprüfen, ob ein Objekt getroffen wurde
                if (Physics.Raycast(ray, out hit))
                {
                    // Überprüfen, ob das getroffene Objekt ein Kind des Prefabs ist
                    Transform hitTransform = hit.transform;

                    // Wenn das getroffene Objekt ein Kind des Prefabs ist
                    if (hitTransform.IsChildOf(prefab.transform))
                    {
                        // Alle Kinder des Prefabs durchgehen und deaktivieren, außer das angeklickte Kind
                        foreach (Transform child in prefab.transform)
                        {
                            if (child != hitTransform)
                            {
                                // Alle anderen Kinder deaktivieren
                                child.gameObject.SetActive(false);
                            }
                            else
                            {
                                // Das angeklickte Kind sichtbar lassen
                                child.gameObject.SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }
}
