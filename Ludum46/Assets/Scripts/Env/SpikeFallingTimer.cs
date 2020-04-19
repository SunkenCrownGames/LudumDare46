﻿using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;
using UnityEngine.UIElements;

public class SpikeFallingTimer : MonoBehaviour
{
    [SerializeField] private Vector3 m_spawnOffset;
    
    private Timer timer;
    public float m_spawnTime = 5;
    private Position location;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = new Timer(m_spawnTime, m_spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Tick(1))
        {
            Spawn();
        }
    }

    public GameObject spike;
    void Spawn()
    {
        Instantiate(spike, transform.position + m_spawnOffset, spike.transform.rotation, null);
    }

    
}
