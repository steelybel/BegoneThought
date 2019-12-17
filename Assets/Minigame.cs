using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public float xAxis;
    public float yAxis;
    public bool buttonHold;
    public bool buttonTap;
    private float timer;
    public bool finish = false;
    [SerializeField]
    private float timerSet;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerSet;
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("P1_Horizontal");
        yAxis = Input.GetAxis("P1_Vertical");
        buttonHold = Input.GetButton("P1_Fire");
        buttonTap = Input.GetButtonDown("P1_Fire");

        if (timer > 0f) timer -= Time.deltaTime;
    }
}
