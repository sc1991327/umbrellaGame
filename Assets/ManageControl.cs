using UnityEngine;
using System.Collections;

enum GamePage { start, play, end };

public class ManageControl : MonoBehaviour {

    public GameObject StartUI;
    public GameObject Player;
    public GameObject EndUI;

    public GameObject RestartButton;
    private GamePage gamePage = GamePage.start;

	// Use this for initialization
	void Start () {

        ShowStartPage();

	}
	
	// Update is called once per frame
	void Update () {

        switch (gamePage)
        {
            case GamePage.start:
                handleStartUI();
                break;

            case GamePage.play:
                break;

            case GamePage.end:
                handleEndUI();
                break;
        }

	}

    private void handleStartUI(){
        // mouse
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (StartUI.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                ShowPlayPage();
            }
        }

        // phone
        //if (Input.touchCount == 1)
        //{
        //    Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //    Vector2 touchPos = new Vector2(wp.x, wp.y);
        //    if (StartUI.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        //    {
        //        ShowPlayPage();
        //    }
        //}
    }

    private void handleEndUI()
    {
        // mouse
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (RestartButton.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                ShowPlayPage();
            }
        }
    }

    public void ShowStartPage()
    {
        gamePage = GamePage.start;

        StartUI.SetActive(true);
        Player.SetActive(false);
        EndUI.SetActive(false);
    }

    public void ShowPlayPage(){

        gamePage = GamePage.play;

        StartUI.SetActive(false);
        Player.SetActive(true);
        EndUI.SetActive(false);

        Player.transform.position = new Vector3(0,0,0);
        Camera.main.transform.position = new Vector3(0, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }

    public void ShowEndPage()
    {
        gamePage = GamePage.end;

        StartUI.SetActive(false);
        Player.SetActive(false);
        EndUI.SetActive(true);
    }

}
