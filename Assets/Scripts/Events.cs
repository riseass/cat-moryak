using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // Объект не уничтожается при загрузке новой сцены
    }

    public void NextLvl() => SceneManager.LoadScene(2);
    public void NextLv2() => SceneManager.LoadScene(3);
    public void Menu() => SceneManager.LoadScene(0);
    public void Level() => SceneManager.LoadScene(1);
    public void Quit() => Application.Quit();
}