using UnityEngine;

public class Cloner : MonoBehaviour
{
    public GameObject prefab; // Префаб, который нужно клонировать

    [Header("Cloning Parameters")]
    public int countX = 3; // Количество клонов по оси X
    public int countY = 3; // Количество клонов по оси Y
    public int countZ = 3; // Количество клонов по оси Z
    public float spacingX = 1.0f; // Расстояние между клонами по оси X
    public float spacingY = 1.0f; // Расстояние между клонами по оси Y
    public float spacingZ = 1.0f; // Расстояние между клонами по оси Z
    public Vector3 rotation = Vector3.zero; // Поворот каждого клона

    void Start()
    {
        CloneObjects();
    }

    void CloneObjects()
    {
        Quaternion rotationQuat = Quaternion.Euler(rotation);
        Vector3 startPosition = transform.position - new Vector3((countX - 1) * spacingX / 2, (countY - 1) * spacingY / 2, (countZ - 1) * spacingZ / 2);

        for (int i = 0; i < countX; i++)
        {
            for (int j = 0; j < countY; j++)
            {
                for (int k = 0; k < countZ; k++)
                {
                    Vector3 position = startPosition + new Vector3(i * spacingX, j * spacingY, k * spacingZ);
                    Instantiate(prefab, position, rotationQuat);
                }
            }
        }
    }
}