using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WavesManager : MonoBehaviour
{
    public static WavesManager instance;

    public List<WaveSpawner_Chapter17> waves;
    public UnityEvent onChanged;

    public void AddWave(WaveSpawner_Chapter17 wave)
    {
        waves.Add(wave);
        onChanged.Invoke();
    }
    
    public void RemoveWave(WaveSpawner_Chapter17 wave)
    {
        waves.Remove(wave);
        onChanged.Invoke();
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogError("Duplicated WavesManager", gameObject);
    }
}


