using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public GameObject settings;
    void Start()
    {
        settings.SetActive(false);
        AwakenSettings();
    }
    IEnumerator AwakenSettings() 
    {
        yield return new WaitForSeconds(12);
        settings.SetActive(true);
    }
}
