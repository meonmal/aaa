using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    static Manager instance;
    static bool init = false;

    #region Contents
    GameManager gameManager = new GameManager();
    ObjectManager objectManager = new ObjectManager();
    PoolManager poolManager = new PoolManager();
    
    public static GameManager Game
    {
        get
        {
            return Instance?.gameManager;
        }
    }

    public static ObjectManager ObjectManager
    {
        get
        {
            return Instance?.objectManager;
        }
    }

    public static PoolManager PoolManager
    {
        get
        {
            return Instance?.poolManager;
        }
    }
    #endregion


    #region Core
    DataManager dataManager = new DataManager();
    ResourceManager resourceManager = new ResourceManager();
    SceneManager sceneManager = new SceneManager();
    SoundManager soundManager = new SoundManager();
    UIManager uiManager = new UIManager();

    public static DataManager DataManager
    {
        get
        {
            return Instance?.dataManager;
        }
    }

    public static ResourceManager ResourceManager
    {
        get
        {
            return Instance?.resourceManager;
        }
    }

    public static SceneManager SceneManager
    {
        get
        {
            return Instance?.sceneManager;
        }
    }

    public static SoundManager SoundManager
    {
        get
        {
            return Instance?.soundManager;
        }
    }

    public static UIManager UIManager
    {
        get
        {
            return Instance?.uiManager;
        }
    }
    #endregion

    public static Manager Instance
    {
        get
        {
            if(init == false)
            {
                init = true;

                GameObject gogo = GameObject.Find("GameManager");
                if(gogo == null)
                {
                    gogo = new GameObject() { name = "GameManager" };
                    gogo.AddComponent<Manager>();
                }

                DontDestroyOnLoad(gogo);
                init = gogo.GetComponent<Manager>();
            }
            return instance;
        }
    }
}
