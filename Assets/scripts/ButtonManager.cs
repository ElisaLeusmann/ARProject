using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ButtonManager : MonoBehaviour
{
    public Button showBonesButton;     // Referenz zu deinem Button
    public ARPlacementInteractable placementInteractable; // Referenz zum BodyModelController-Skript

    private GameObject spawnedModel;   // Referenz zum gespannten Prefab

    void Start()
    {
        // Button zu Beginn deaktivieren
        if (showBonesButton != null)
        {
            showBonesButton.gameObject.SetActive(false);
        }
    }

    // Funktion, um das gespawnte Modell zu setzen (wird von einem anderen Skript aufgerufen)
    public void SetSpawnedModel(GameObject model)
    {
        spawnedModel = model;

        // Button aktivieren und Funktion verknüpfen
        if (spawnedModel != null && showBonesButton != null)
        {
            showBonesButton.gameObject.SetActive(true);

            // BodyModelController vom gespannten Modell abrufen
            bodyModelController = spawnedModel.GetComponent<BodyModelController>();

            if (bodyModelController != null)
            {
                showBonesButton.onClick.AddListener(bodyModelController.ShowBonesOnly);
            }
        }
    }
}
