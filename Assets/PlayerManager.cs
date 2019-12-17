using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Player[] players;
    public GameObject[] minigames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("P1_Fire"))
        {
            if (!players[0].inMinigame)
            AssignMinigame(0);
        }
        if (Input.GetButtonDown("P2_Fire"))
        {
            if (!players[1].inMinigame)
                AssignMinigame(1);
        }
    }
    void AssignMinigame(int player)
    {
        int butt;
        butt = (int)Random.Range(0.0f, (float)minigames.Length - 1.0f);
        while (minigames[butt].activeSelf)
        {
            butt = (int)Random.Range(0.0f, (float)minigames.Length - 1.0f);
            Debug.Log(butt);
        }
        minigames[butt].SetActive(true);
        minigames[butt].GetComponent<Minigame>().finish = false;
        players[player].SetMini(minigames[butt].GetComponent<Minigame>());
        Vector3 pos = new Vector3(players[player].miniWindow.transform.position.x, players[player].miniWindow.transform.position.y, 1);
        minigames[butt].transform.position = pos;
    }
}
