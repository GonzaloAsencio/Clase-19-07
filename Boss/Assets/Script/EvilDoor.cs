using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class EvilDoor : MonoBehaviour
{
    public static event Action ActivarHp;
    CinemachineImpulseSource impulse;
    public GameObject Key;

    void Start()
    {
        impulse = transform.GetComponent<CinemachineImpulseSource>();
        ActivarHp?.Invoke();
    }

 
    public void SummonKey()
    {
        Instantiate(Key, transform.position, transform.rotation);
    }
    public void Shake()
    {
        impulse.GenerateImpulse();
    }
}
