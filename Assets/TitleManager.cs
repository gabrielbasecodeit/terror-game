﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
	void Update()
    {
		if(Input.GetKey(KeyCode.Return))
		{
			SceneManager.LoadScene("Main");
		}
    }
}
