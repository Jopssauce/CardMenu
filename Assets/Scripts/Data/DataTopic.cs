﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Topic", menuName = "Topic Data")]
public class DataTopic : ScriptableObject
{
    public string TopicName;
    public Sprite Background;
    public List<DataCard> Cards;
}
