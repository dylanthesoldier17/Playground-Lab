﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PassAudioSource : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
