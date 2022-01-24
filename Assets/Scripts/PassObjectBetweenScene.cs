using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PassObjectBetweenScene : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
