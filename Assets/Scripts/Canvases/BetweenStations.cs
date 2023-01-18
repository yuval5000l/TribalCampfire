using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetweenStations : MonoBehaviour
{
    [SerializeField] private BorderScript upperBorder;
    [SerializeField] private BorderScript lowerBorder;
    private bool slideOut = false;
    [SerializeField] private GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void SlideOut()
    {
        upperBorder.SlideOut();
        lowerBorder.SlideOut();
    }
}
