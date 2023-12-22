using System;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    void Start() => GetComponent<Button>().onClick.AddListener(StartNewGame);

    private void StartNewGame() => GameManager.Instance.NewGame();
}
