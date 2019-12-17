using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanYouPetTheDog : MonoBehaviour
{
    public GameObject hand;
    public GameObject dog;
    private Minigame mini;
    private int numPresses = 0;
    bool buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        mini = GetComponent<Minigame>();
        hand.transform.localPosition = new Vector3(0.0f, 4.0f, 1.0f);
        numPresses = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (mini.finish == true)
        {
            Reset();
            gameObject.SetActive(false);
        }
        if (numPresses >= 10)
        {
            mini.finish = true;
        }
        if (Input.GetButtonDown(mini.button))
        {
            hand.transform.localPosition = new Vector3(0, hand.transform.localPosition.y - 0.25f, 0);
            numPresses++;
        }
        else
        {
            hand.transform.localPosition = new Vector3(0, hand.transform.localPosition.y + 0.01f, 0);
        }
    }
    void Reset()
    {
        numPresses = 0;
        hand.transform.localPosition = new Vector3(0.0f, 4.0f, 1.0f);
    }
}
