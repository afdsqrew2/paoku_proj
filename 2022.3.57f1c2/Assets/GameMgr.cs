using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr Instance;
    public ParticleSystem caidaiParticles;
    
    public void Awake()
    {
        Instance = this;
        caidaiParticles.gameObject.SetActive(false);
    }

    private void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            caidaiParticles.Stop();
            caidaiParticles.Simulate(0.0f, true, true); // 重置到初始状态
            caidaiParticles.Play();
        }
    }

    public void ShowCele()
    {
        caidaiParticles.gameObject.SetActive(true);
        caidaiParticles.Stop();
        caidaiParticles.Simulate(0.0f, true, true); // 重置到初始状态
        caidaiParticles.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
