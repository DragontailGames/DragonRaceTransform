using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    #region singleton

    public static Manager Instance = null;
    void Awake()
    {
        if (Instance == null) Instance = this;
        else if (Instance != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public List<Level> levels = new List<Level>();

    public int currentLevel = 0;

    public GameManager gameManager;

    public CanvasManager canvasManager;

    public MenuManager menuManager;
}
