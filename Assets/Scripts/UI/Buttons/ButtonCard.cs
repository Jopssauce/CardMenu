﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCard : UIButton
{
    UIMainTopic uiMainTopic;
    public override void Start()
    {
        base.Start();
    }
    //OnEnable because object starts off as enabled
    private void OnEnable()
    {
        Initialize();
        uiMainTopic = GetComponentInParent<UIMainTopic>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        uiMainTopic.CardFacePanel.SetActive(true);
    }
}