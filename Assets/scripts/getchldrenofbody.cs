using UnityEngine;

public class MeshAccess : MonoBehaviour
{
    public GameObject prefab;  // Das Prefab, das die einzelnen Meshes enthält

    void Start()
    {
       
        
        // Hole alle MeshFilter-Komponenten in den Kindern des Prefabs
        MeshFilter[] meshFilters = prefab.GetComponentsInChildren<MeshFilter>();

        // Durchlaufe alle MeshFilter und greife auf die Meshes zu
        foreach (MeshFilter meshFilter in meshFilters)
        {
            // Zugriff auf das Mesh des MeshFilters
            Mesh mesh = meshFilter.sharedMesh;
            Debug.Log("Mesh Name: " + mesh.name);

            // Hier kannst du mit dem Mesh weiterarbeiten, z.B. es skalieren, färben, etc.
            // Zum Beispiel: Setze alle Meshes auf eine bestimmte Farbe
            MeshRenderer meshRenderer = meshFilter.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                //meshRenderer.material.color = Color.red; // Setze die Farbe auf Rot
                //hideotherchildren();
            }
        }
    }

    //void hideotherchildren()
    // {
    //     // Get all MeshRenderers in the prefab's children
    //     MeshRenderer[] meshRenderers = prefab.GetComponentsInChildren<MeshRenderer>();

    //     // Define the names of the meshes you want to keep visible
    //     string[] meshesToShow = { "Wheel", "Body" }; // Example names of meshes you want to keep visible

    //     // Iterate over all MeshRenderers
    //     foreach (MeshRenderer meshRenderer in meshRenderers)
    //     {
    //         // Check if the current mesh is in the list of meshes you want to keep visible
    //         bool shouldShow = false;
    //         foreach (string meshName in meshesToShow)
    //         {
    //             if (meshRenderer.gameObject.name == meshName)
    //             {
    //                 shouldShow = true;
    //                 break;
    //             }
    //         }

    //         // Hide or show the MeshRenderer based on the condition
    //         meshRenderer.gameObject.SetActive(shouldShow);
    //     }
    // }

}
