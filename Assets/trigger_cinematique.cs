using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class trigger_cinematique : MonoBehaviour
{
    [SerializeField] private PlayableDirector cinematic;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        cinematic.Play();
    }
}
