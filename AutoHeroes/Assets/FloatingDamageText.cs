﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingDamageText : MonoBehaviour {

    public Animator animator;
    private Text damageText;


    private void OnEnable()
    {
        
    }

    // Use this for initialization
    void Start ()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);
        damageText = animator.GetComponent<Text>();
	}
	
    public void SetText(string text)
    {
        animator.GetComponent<Text>().text = text;
    }

}
