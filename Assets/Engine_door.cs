using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Engine_door : MonoBehaviour
{
    private bool isOpen = true;
    public AudioSource doorOpenSound;

    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                _animator.SetBool("isOpen", true);
                doorOpenSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _animator.SetBool("isOpen", false);
            doorOpenSound.Play();
        }
    }
}
