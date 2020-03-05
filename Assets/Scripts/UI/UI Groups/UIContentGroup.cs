﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIContentGroup : UIGroup
{
    public GameObject Header;
    [Header("Tab Buttons")]
    public GameObject CardButton;
    public GameObject VideoButton;

    [Header("Video UI Elements")]
    public GameObject VideoPanel;
    public GameObject VideoFrame;

    [Header("Card UI Elements")]
    public ScrollRect CardGridView;
}
