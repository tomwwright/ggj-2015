﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ModifierActions : MonoBehaviour {
    private Dictionary<string, bool> actionList;

    public /*const*/ string playerLeft;
    public /*const*/ string playerRight;
    public /*const*/ string playerJump;
    public /*const*/ string playerShoot;
    public /*const*/ string playerGrab;
    public /*const*/ string cameraEnabled;

	// Use this for initialization
	void Start () {
        actionList = new Dictionary<string, bool>();
	}

    public void setActionEnabled(string actionName, bool isEnabled)
    {
        actionList.Add(actionName, isEnabled);
    }

    public bool getActionEnabled(string actionName)
    {
        bool isEnabled = true;
        actionList.TryGetValue(actionName, out isEnabled);
        return isEnabled;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}