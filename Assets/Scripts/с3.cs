using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    // Вариант 1: Загрузка по индексу сцены (порядковый номер в Build Settings)
    public void LoadBySceneIndex()
    {
        SceneManager.LoadScene(3); // Загружает сцену с индексом 3
    }

    // Вариант 2: Загрузка по имени сцены
    public void LoadBySceneName()
    {
        SceneManager.LoadScene("Level3"); // Замени "Level3" на имя своей сцены
    }
}