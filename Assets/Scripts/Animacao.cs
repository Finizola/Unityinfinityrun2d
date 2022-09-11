using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacao : MonoBehaviour
{

    private Animator playeranimator2d;
    private SpriteRenderer sprite;


    public const string PLAYER_SMOKE = "Smoke";
    public const string PLAYER_WALK = "Walk";
    public const string PLAYER_JUMP = "Jump";
    public const string PLAYER_DIE = "Die";

    private string currentState;

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        playeranimator2d.Play(newState);
        currentState = newState;
    }

    void Start()
    {
        playeranimator2d = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

}
