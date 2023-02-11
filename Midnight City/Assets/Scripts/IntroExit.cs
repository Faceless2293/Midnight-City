using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroExit : MonoBehaviour
{
    private void Start()
    {
        EndCut();
    }
    IEnumerator EndCut() 
    {
        yield return new WaitForSeconds(16);
        Destroy(gameObject);
    }
}
