﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCard : UIButton
{
    public DataCard CardData;
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
        GetComponent<Image>().sprite = CardData.UISprite;
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        uiMainTopic.CardFace.CardData = CardData;
        uiMainTopic.CardFacePanel.SetActive(true);
    }
}
