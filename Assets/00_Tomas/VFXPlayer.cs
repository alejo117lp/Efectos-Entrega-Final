using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.Events;

public class VFXPlayer : MonoBehaviour
{
    [SerializeField]
    private float interval = 1.0f; // Interval between VFX plays in seconds


    [SerializeField]
    private VisualEffect visualEffect; // Reference to the Visual Effect component

    [SerializeField] private float timer;
    [SerializeField] UnityEvent Event;

    private void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if the timer has reached the desired interval
        if (timer >= interval)
        {
            // Reset the timer
            timer = 0.0f;

            // Play the Visual Effect
            PlayVisualEffect();
        }
    }

    private void PlayVisualEffect()
    {
        Event.Invoke();
        // Check if the Visual Effect component is not null
        //if (visualEffect != null)
        //{
        //    visualEffect.Stop();
        //    // Check if the Visual Effect is not already playing
        //    if (!visualEffect.isActiveAndEnabled)
        //    {
        //        // Play the Visual Effect
               
        //        visualEffect.Play();
        //    }
        //}
    }
}

