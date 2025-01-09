using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_blood_script : MonoBehaviour
{
    // Start is called before the first frame update
    public BonesOrgansBloodvessels bloodscript;
    void Start()
    {
        bloodscript = FindObjectOfType<BonesOrgansBloodvessels>();
        if (bloodscript != null)
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
        public void ToggleBlood()
    {
        if (bloodscript != null)
        {
            bloodscript.ShowOnlyBloodVessels();

        }
    }
}

