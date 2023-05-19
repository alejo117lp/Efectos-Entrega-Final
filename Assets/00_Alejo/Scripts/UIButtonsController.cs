using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonsController : MonoBehaviour
{
    public void ChangeToGrowPlants() {
        SceneManager.LoadScene("GrowingEffect");
    }

    public void ChangeToRayEffect() {
        SceneManager.LoadScene("Efecto Rayo");
    }

    public void ChangeToGrifo() {
        SceneManager.LoadScene("Grifo");
    }
}
