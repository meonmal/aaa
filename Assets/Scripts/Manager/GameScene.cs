using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject GoblinPrefab;
    public GameObject SnakePrefab;

    GameObject Snake;
    GameObject Goblin;
    GameObject Player;

    private void Start()
    {
        GameObject.Instantiate(PlayerPrefab);

        Snake = GameObject.Instantiate(SnakePrefab);
        Goblin = GameObject.Instantiate(GoblinPrefab);
        

        GameObject gogo = new GameObject() { name = "Monsters" };
        Snake.transform.parent = gogo.transform;
        Goblin.transform.parent = gogo.transform;

        PlayerPrefab.AddComponent<PlayerController>();
    }
}
