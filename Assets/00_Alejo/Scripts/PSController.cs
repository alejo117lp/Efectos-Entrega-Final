using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PSController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    [Header("Start LifeTime Range"), Range(0.27f, 1.45f), SerializeField] 
    private float startLTRange;
    private ParticleSystem.MainModule main;

    // Start is called before the first frame update
    void Start()
    {
         main = _particleSystem.main;
         _particleSystem.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SetActivePS();
            ChangeStarLifeTime();
        }
    }

    public void SetActivePS()
    {
        _particleSystem.Play();
    }

    public void ChangeStarLifeTime()
    {
        main.startLifetime = startLTRange;
    }

    public void ChangeStartColor()
    {
        main.startColor = Color.red;
    }
}
