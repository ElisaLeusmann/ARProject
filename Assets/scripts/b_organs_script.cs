using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_organs_script : MonoBehaviour
{
    // Start is called before the first frame update
    public BonesOrgansBloodvessels organscript;
    void Start()
    {
        organscript = FindObjectOfType<BonesOrgansBloodvessels>();
        if (organscript != null)
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
        public void ToggleOrgans()
    {
        if (organscript != null)
        {
            organscript.ShowOnlyOrgans();

        }
    }
}

