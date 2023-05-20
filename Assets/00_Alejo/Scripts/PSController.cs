using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class PSController : MonoBehaviour {
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] GameObject gameObjectTxT;
    [SerializeField] float duracionTexto = 5f;

    [Header("Start LifeTime Range"), Range(0.27f, 1.45f), SerializeField]
    private float startLTRange;

    [Header("Color Settings")]
    [SerializeField] private Slider red;
    [SerializeField] private Slider green;
    [SerializeField] private Slider blue;
    [Header("Values Settings")]
    [SerializeField] private Slider slider1;
    [SerializeField] private Slider slider2;
    [SerializeField] private Slider Slider3;
    private ushort clicksCounterTrail = 0;
    private ParticleSystem.MainModule main;
    private ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime;
    private ParticleSystem.TrailModule trailModule;

    void Start() {
        main = _particleSystem.main;
        velocityOverLifetime = _particleSystem.velocityOverLifetime;
        trailModule = _particleSystem.trails;
        gameObjectTxT.SetActive(false);
    }

    public void SetActivePS() {
        _particleSystem.Play();
    }

    public void ChangeStarLifeTime() {
        main.startLifetime = startLTRange;
    }

    public void ChangeColorOL() {
        Color newMinColor = new(red.value, green.value, blue.value);
    }

    public void StartSpeed() {

        StartCoroutine("OcultarTexto");
        main.startSpeed = slider1.value;
    }

    public void VelocityOL() {
        velocityOverLifetime.speedModifier = slider2.value;
    }

    public void TrailsMod() {

        if(clicksCounterTrail== 0) {
            trailModule.textureMode = ParticleSystemTrailTextureMode.Tile;
            clicksCounterTrail= 1;
        }

        else if(clicksCounterTrail== 1) {
            trailModule.textureMode = ParticleSystemTrailTextureMode.Stretch;
            clicksCounterTrail = 0;
        }
        
    }

    IEnumerator OcultarTexto() {

        gameObjectTxT.SetActive(true);
        yield return new WaitForSeconds(duracionTexto);
        gameObjectTxT.SetActive(false);
    }
}
