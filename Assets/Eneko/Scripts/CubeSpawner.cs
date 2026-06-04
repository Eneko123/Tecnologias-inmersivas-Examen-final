using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject cuboPrefab;

    void Start()
    {
        StartCoroutine(SpawnCubesAfterDelay(0.5f));
    }

    IEnumerator SpawnCubesAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SpawnCubes();
    }

    void SpawnCubes()
    {
        Vector3 frente = playerPosition.position + new Vector3(2, 0, 0);

        // Cubo rojo a la izquierda
        GameObject cubo1 = Instantiate(cuboPrefab, frente + new Vector3(0, 0, 1), Quaternion.identity);
        cubo1.GetComponent<Renderer>().material.color = Color.red;
        cubo1.GetComponent<InteractiveCube>().miColor = Color.red;

        // Cubo azul a la derecha
        GameObject cubo2 = Instantiate(cuboPrefab, frente + new Vector3(0, 0, -1), Quaternion.identity);
        cubo2.GetComponent<Renderer>().material.color = Color.blue;
        cubo2.GetComponent<InteractiveCube>().miColor = Color.blue;
    }
}