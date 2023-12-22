using UnityEngine;
using UnityEngine.UI;

public class QuitGameButton : MonoBehaviour
{
    void Start() => GetComponent<Button>().onClick.AddListener(QuitGame);

    private void QuitGame() => GameManager.Instance.QuitGame();
}
