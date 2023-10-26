using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    [SerializeField]
    private Animator m_Anim;
    public AudioSource doorOpenSound;

    private int Anim_DoorOpen;

    private void Awake()
    {
        Anim_DoorOpen = Animator.StringToHash("DoorOpen");
    }

    public void OpenDoor()
    {
        m_Anim.SetBool(Anim_DoorOpen, true);
        doorOpenSound.Play();
    }

    public void CloseDoor()
    {
        m_Anim.SetBool(Anim_DoorOpen, false);
        doorOpenSound.Play();
    }
}
