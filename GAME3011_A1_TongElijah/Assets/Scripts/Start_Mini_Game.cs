using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Mini_Game : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject MiniGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnstartButtonPressed()
    {
        gameObject.SetActive(false);
        text.SetActive(false);

        MiniGame.SetActive(true);
    }
}
