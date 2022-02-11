using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndText : MonoBehaviour
{
    public GameObject BoxCollider;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();

        text.color = new Color(0, 0, 0, 0);
    }

    void Update()
    {
        if(BoxCollider.GetComponent<EndGame>().hit == true)
        {
            text.color = new Color(1, 0, 0, 1);

            if (Input.GetButtonDown("Jump"))
            {
                SceneManager.LoadScene("Level");
            }
        }
    }
}
