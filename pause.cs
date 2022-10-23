using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
   public GameObject panel;

    public void pausegame()
    { 
        Time.timeScale = 0f;
        panel.SetActive(true);       
    }
}
