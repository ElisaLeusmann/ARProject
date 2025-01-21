using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_heart_script : MonoBehaviour
{
    // Start is called before the first frame update
    public BonesOrgansBloodvessels heartscript;
    void Start()
    {
        heartscript = FindObjectOfType<BonesOrgansBloodvessels>();
        if (heartscript != null)
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
    public void ToggleHeart()
    {
        if (heartscript != null)
        {
            heartscript.ShowOnlyHeart();

        }
    }
}

