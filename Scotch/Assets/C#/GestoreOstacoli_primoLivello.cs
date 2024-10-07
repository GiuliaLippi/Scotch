using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestoreOstacoli_primoLivello : MonoBehaviour
{
  IEnumerator InstantiateWithDelay(GameObject prefab, Vector3 position, float delay, int amount)
{
    for(int i = 1 ; i <= amount;i++)
    {
        yield return new WaitForSeconds(delay);
        Object.Instantiate(prefab, position, Quaternion.identity);

    }
}

void Start()
{
    GameObject Mauro1 = Resources.Load("Mauro I") as GameObject;
    GameObject Mauro2 = Resources.Load("Mauro II") as GameObject;
    GameObject Mauro3 = Resources.Load("Mauro III") as GameObject;
    GameObject Mauro4 = Resources.Load("Mauro IV") as GameObject;
    GameObject Mauro5 = Resources.Load("Mauro V") as GameObject;
    GameObject Mauro6 = Resources.Load("Mauro VI") as GameObject;

    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 2f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 7f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 7f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 11f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 11f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 15f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 19f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 19f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 20f, 1));
StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 25f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 29f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 30f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 30f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 35f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 40f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 40f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 45f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 45f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 45f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 50f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 51f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 52f, 1));










}

void Update()
{

}
}
