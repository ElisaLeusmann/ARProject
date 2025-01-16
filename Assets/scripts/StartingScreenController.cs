using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartingScreenController : MonoBehaviour
{
    public void StartGame()
    {
        // Load the next scene 
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}
