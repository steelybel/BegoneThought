using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanYouPetTheDog : MonoBehaviour
{
    public GameObject hand;
    public GameObject dog;
    private BoxCollider2D dogBox;
    private BoxCollider2D handBox;
    private bool hasCollided = false;
    private Minigame mini;
    private int numPets = 0;
    private float handPos = 4;
    bool buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        dogBox = dog.GetComponent<BoxCollider2D>();
        handBox = hand.GetComponent<BoxCollider2D>();
        mini = GetComponent<Minigame>();
        hand.transform.localPosition = new Vector3(0.0f, 4.0f, 1.0f);
        numPets = 0;
        handPos = 4;
        hasCollided = false;
    }

    // Update is called once per frame
    void Update()
    {
        handPos = Mathf.Clamp(handPos, 2, 4);
        hand.transform.localPosition = new Vector3(0.0f, handPos, 1.0f);
        if (mini.finish == true)
        {
            Reset();
            gameObject.SetActive(false);
        }
        if (handBox.IsTouching(dogBox) && !hasCollided)
        {
            numPets++;
            Debug.Log("barlk bark");
            hasCollided = true;
        }
        if (!handBox.IsTouching(dogBox))
        {
            hasCollided = false;
        }
        if (numPets >= 5)
        {
            mini.finish = true;
        }
        if (Input.GetButton(mini.button))
        {
            handPos -= 0.1f;
            //numPets++;
        }
        else
        {
            handPos += 0.05f;
        }
    }
    void Reset()
    {
        numPets = 0;
        handPos = 4;
        hasCollided = false;
        hand.transform.localPosition = new Vector3(0.0f, 4.0f, 1.0f);
    }
}
