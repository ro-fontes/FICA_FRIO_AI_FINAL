using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadcontrol : MonoBehaviour
{
    public LoadingScreenBarSystem loadingscreen;
    public GameObject video;
    public void loadingLevel(int level)
    {
        loadingscreen.loadingScreen(level);
    }
}
