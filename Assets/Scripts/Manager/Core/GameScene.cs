using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{

    private void Start()
    {
        //Resources.Load<GameObject>("Prefab");

        var a = Resources.Load<GameObject>("Prefabs");

        void Start()
        {
            Manager.ResourceManager.LoadAllAsync<GameObject>("Prefabs", (key, count, totalCount) =>
            {
                Debug.Log($"{key} {count}/{totalCount}");

                if (count == totalCount)
                {
                    Manager.ResourceManager.LoadAllAsync<TextAsset>("Data", (key3, count3, totalCount3) =>
                    {
                        if (count3 == totalCount3)
                        {
                            StartLoaded();
                        }
                    });
                }
            });
        }
    }

    void StartLoaded()
    {
        var player = Manager.ResourceManager.Instantiate("Slime_01.prefab");
        player.AddComponent<PlayerController>();

        var snake = Manager.ResourceManager.Instantiate("Snake_01.prefab");
        var goblin = Manager.ResourceManager.Instantiate("Goblin_01.prefab");
        var joystick = Manager.ResourceManager.Instantiate("UI_Joystick.prefab");
        joystick.name = "@UI_Joystick";

        var map = Manager.ResourceManager.Instantiate("Map.prefab");
        map.name = "Map";
    }
}
