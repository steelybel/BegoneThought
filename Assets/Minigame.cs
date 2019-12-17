using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public string xAxis;
    public string yAxis;
    public string button;
    private float timer;
    public bool finish = false;
    [SerializeField]
    private float timerSet = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerSet;
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > 0f) timer -= Time.deltaTime;
    }
}
