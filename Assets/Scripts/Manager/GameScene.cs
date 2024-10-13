using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject SlimePrefab;
    public GameObject GoblinPrefab;
    public GameObject SnakePrefab;

    GameObject Snake;
    GameObject Goblin;
    GameObject Slime;

    private void Start()
    {
        GameObject.Instantiate(SlimePrefab);

        Snake = GameObject.Instantiate(SnakePrefab);
        Goblin = GameObject.Instantiate(GoblinPrefab);
        Slime = GameObject.Instantiate(SlimePrefab);

        GameObject gogo = new GameObject() { name = "Monsters" };
        Snake.transform.parent = gogo.transform;
        Goblin.transform.parent = gogo.transform;

        SlimePrefab.AddComponent<PlayerController>();

        Camera.main.GetComponent<CameraController>().target = Slime;
    }
}
