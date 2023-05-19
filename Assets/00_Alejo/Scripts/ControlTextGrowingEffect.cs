using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTextGrowingEffect : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] float timeToAppearText = 5f;

    private void Start() {
        StartCoroutine("ActiveText");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            text1.SetActive(false);
        }
    }

    IEnumerator ActiveText() {
        yield return new WaitForSeconds(timeToAppearText);
        text1.SetActive(true);
    }
}
