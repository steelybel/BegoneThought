using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera miniWindow;
    private charController control;
    private Minigame minigame;
    public bool inMinigame;
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<charController>();
    }

    // Update is called once per frame
    void Update()
    {
        inMinigame = (minigame != null);
        switch (inMinigame)
        {
            case false:
                control.enabled = true;
                break;
            case true:
                control.enabled = false;
                break;
            default:
                control.enabled = true;
                break;
        }
        if (minigame != null)
        {
            if (minigame.finish)
            {
                minigame = null;
            }
        }
    }
    public void SetMini(Minigame m)
    {
        minigame = m;
        minigame.xAxis = control.xAxis;
        minigame.yAxis = control.yAxis;
        minigame.button = control.button;
    }
}
