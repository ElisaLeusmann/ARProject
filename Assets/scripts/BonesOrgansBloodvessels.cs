using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class BonesOrgansBloodvessels : MonoBehaviour
{
    // Reference to the spawned prefab
    public ARPlacementInteractable placementInteractable;
    public GameObject b_skeleton;
    public GameObject b_organs;
    public GameObject b_blood;
    public GameObject b_full;

    public void Start()
    {
        //placementInteractable = GetComponent<ARPlacementInteractable>();
        // Finde das `interactable_script` und hole die zugehörige GameObject-Komponente
        // interactable_script interactableScript = FindObjectOfType<interactable_script>();
        // if (interactableScript != null)
        // {
        //     // Hole den ARPlacementInteractable vom selben GameObject
        //     placementInteractable = interactableScript.GetComponent<ARPlacementInteractable>();
        //     if (placementInteractable != null)
        //     {
        //         Debug.Log("ARPlacementInteractable erfolgreich gefunden!");
        //     }
        //     else
        //     {
        //         Debug.LogError("ARPlacementInteractable konnte nicht gefunden werden!");
        //     }
        // }
        // else
        // {
        //     Debug.LogError("interactable_script konnte nicht gefunden werden!");
        // }
        //button = GetComponent<Button>();


        b_skeleton_script skeletonScript = (b_skeleton_script)FindObjectOfType(typeof(b_skeleton_script), true);
        if (skeletonScript != null)
        {
            b_skeleton = skeletonScript.gameObject;
            Debug.Log("lalala " + b_skeleton.name);
        }
        else
        {
            Debug.LogError("GameObject mit b_skeleton_script nicht gefunden (auch nicht inaktive)!");
        }

        b_organs_script organsScript = (b_organs_script)FindObjectOfType(typeof(b_organs_script), true);
        if (organsScript != null)
        {
            b_organs = organsScript.gameObject;
            Debug.Log("lalala " + b_organs.name);
        }
        else
        {
            Debug.LogError("GameObject mit b_organs_script nicht gefunden (auch nicht inaktive)!");
        }

        b_blood_script bloodScript = (b_blood_script)FindObjectOfType(typeof(b_blood_script), true);
        if (bloodScript != null)
        {
            b_blood = bloodScript.gameObject;
            Debug.Log("lalala " + b_blood.name);
        }
        else
        {
            Debug.LogError("GameObject mit b_blood_script nicht gefunden (auch nicht inaktive)!");
        }

        b_full_script fullScript = (b_full_script)FindObjectOfType(typeof(b_full_script), true);
        if (fullScript != null)
        {
            b_full = fullScript.gameObject;
            Debug.Log("lalala " + b_full.name);
        }
        else
        {
            Debug.LogError("GameObject mit b_full_script nicht gefunden (auch nicht inaktive)!");
        }



        ActivateButton();

    }
    public void ShowOnlyBones()
    {
        Debug.Log("click bones");

        // Get all children with the "Bones" tag within the prefab including inactive ones
        Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform child in children)
        {
            if (child.CompareTag("Bones"))
            {
                child.gameObject.SetActive(true);
            }
            else if (child.CompareTag("Organs") || child.CompareTag("BloodVessels"))
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    public void ShowOnlyOrgans()
    {
        Debug.Log("click organs");
        // Get all children with the "Bones" tag within the prefab including inactive ones
        Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform child in children)
        {
            if (child.CompareTag("Organs"))
            {
                child.gameObject.SetActive(true);
                Debug.Log("in organs");
            }
            else if (child.CompareTag("Bones") || child.CompareTag("BloodVessels"))
            {
                child.gameObject.SetActive(false);
            }
        }
    }

    public void ShowOnlyBloodVessels()
    {

        // Get all children with the "Bones" tag within the prefab
        Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform child in children)
        {
            if (child.CompareTag("BloodVessels"))
            {
                child.gameObject.SetActive(true);
            }
            else if (child.CompareTag("Organs") || child.CompareTag("Bones"))
            {
                child.gameObject.SetActive(false);
            }
        }
    }

        public void ShowFullModel()
    {

        // Get all children with the "Bones" tag within the prefab
        Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform child in children)
        {
            child.gameObject.SetActive(true);

        }
    }

    public void ActivateButton()
    { //ARObjectPlacementEventArgs args

        // Button aktivieren 
        if (b_skeleton != null)
        {
            b_skeleton.SetActive(true);

        }

        if (b_organs != null)
        {
            b_organs.SetActive(true);

        }

        if (b_blood != null)
        {
            b_blood.SetActive(true);

        }
        
        if (b_full != null)
        {
            b_full.SetActive(true);

        }
    }
}
