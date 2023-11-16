using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(BoxCollider2D))]
public class ClickableAnimatedObject : MonoBehaviour
{
    private Animator _animator;
    private AudioSource _actionSound;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _actionSound = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger("Clicked");
        _actionSound.Play();
    }
}
