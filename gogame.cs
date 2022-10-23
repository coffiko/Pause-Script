using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogame : MonoBehaviour
{
   public GameObject panel;

    public void continuegame()
    { 
        Time.timeScale = 1f;
        panel.SetActive(false);       
    }
}
