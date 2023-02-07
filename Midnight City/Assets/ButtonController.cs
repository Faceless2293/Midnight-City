using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button button;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Button>().enabled = false;
    }
}
