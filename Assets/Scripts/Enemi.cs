using UnityEngine;

public class Enemi : MonoBehaviour
{
    public Transform[] SpawnPos;
    private int randomSpot;
    private float WaitTime;
    public float StartwaitTime = 2f; // Добавим значение по умолчанию
    public float speed;

    public Animator Enemyanim;

    private Vector2 previousPosition;
    private bool isMovingRight;

    private void Start()
    {
        WaitTime = StartwaitTime;
        randomSpot = Random.Range(0, SpawnPos.Length);
        previousPosition = transform.position;
    }

    void Update()
    {
        // Сохраняем позицию до перемещения
        Vector2 currentPosition = transform.position;

        // Двигаем врага
        transform.position = Vector2.MoveTowards(currentPosition, SpawnPos[randomSpot].position, speed * Time.deltaTime);

        // Определяем направление движения
        if (currentPosition.x != previousPosition.x)
        {
            isMovingRight = (currentPosition.x > previousPosition.x);
            Enemyanim.SetBool("right", isMovingRight);
            Enemyanim.SetBool("left", !isMovingRight); // Если нужно анимировать влево
        }

        // Если враг достиг точки
        if (Vector2.Distance(transform.position, SpawnPos[randomSpot].position) < 0.2f)
        {
            Enemyanim.SetBool("right", false);
            Enemyanim.SetBool("left", false);

            if (WaitTime <= 0)
            {
                WaitTime = StartwaitTime;
                randomSpot = Random.Range(0, SpawnPos.Length);
            }
            else
            {
                WaitTime -= Time.deltaTime;
            }
        }

        // Обновляем предыдущую позицию
        previousPosition = currentPosition;
    }
}