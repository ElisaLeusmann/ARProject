using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.AR;
using UnityEngine;
using Unity.VisualScripting;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UIElements;


public class b_skeleton_script : MonoBehaviour
{
    // Start is called before the first frame update
    //public ARPlacementInteractable placementInteractable;
    public BonesOrgansBloodvessels skeletonscript;
    void Start()
    {
        //placementInteractable = GetComponent<ARPlacementInteractable>();
        // Finde das `interactable_script` und hole die zugehörige GameObject-Komponente
        skeletonscript = FindObjectOfType<BonesOrgansBloodvessels>();
        if (skeletonscript != null)
        {
            // placementprefab = component.gameObject;
            Debug.Log("placementprefab erfolgreich gefunden!");
            // Hole den ARPlacementInteractable vom selben GameObject

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleBones()
    {
        if (skeletonscript != null)
        {
            skeletonscript.ShowOnlyBones();

        }
    }
}
