using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllers : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip soundClip;
    private Transform _camera;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
        _camera = Camera.main.transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, _camera.position);
        float maxDistance = 10f;
        float normalizedDistance = Mathf.Clamp01(distance / maxDistance);
        audioSource.volume = 1f - normalizedDistance;
    }
}
