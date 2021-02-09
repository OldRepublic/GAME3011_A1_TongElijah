using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Game : MonoBehaviour
{
    [SerializeField] private GameObject MaxRSS;
    [SerializeField] private GameObject HalfRSS;
    [SerializeField] private GameObject QuareterRSS;
    [SerializeField] private GameObject EmptyRSS;

    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject StartPoint;

    public GameObject[,] grid = new GameObject[15, 15];

    // Start is called before the first frame update
    void Start()
    {
        SetupGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupGame()// -200x, -100y --- 200x, -500y and spacing 55
    {
        for(int r = 0; r < 15; r++)//increment through rows
        {
            for(int c = 0; c < 15; c++)//increment through columns
            {
                //print(StartPoint.transform.position.x + " Before");
                //GameObject tile = Instantiate(MaxRSS, StartPoint.transform.position, StartPoint.transform.rotation);//spawn tiles          
                //tile.transform.SetParent(Canvas.transform, false);
                //print(StartPoint.transform.position.x + " After");
                
                if (StartPoint.transform.position.x + 30 < 230)//making sure it stays with in bounds
                {
                    StartPoint.transform.position = new Vector3(StartPoint.transform.position.x + 30, StartPoint.transform.position.y, 0);
                }
                else if (StartPoint.transform.position.y - 30 > -500)//makes sure it stays with in bounds
                {                    
                    StartPoint.transform.position = new Vector3(-200, StartPoint.transform.position.y - 30, 0);
                }

                GameObject tile = Instantiate(MaxRSS, StartPoint.transform.position, StartPoint.transform.rotation);//spawn tiles          
                tile.transform.SetParent(Canvas.transform, false);
            }
        }
    }
}
