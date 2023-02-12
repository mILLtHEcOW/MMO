using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICharacterView : MonoBehaviour
{
    public GameObject[] role;

    private int currentRole = 0;

    public int CurrentRole
    {
        get
        {
            return currentRole;
        }
        set
        {
            currentRole = value;
            this.OnChangeSelect();
        }
    }

    private void OnChangeSelect()
    {
        for (int i = 0; i < role.Length; i++)
        {
            role[i].SetActive(currentRole == i);
        }
    }


}
