using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestoreOstacoli : MonoBehaviour
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
    GameObject Mauro1 = Resources.Load("Mauro1_Veloce") as GameObject;
    GameObject Mauro2 = Resources.Load("Mauro2_Veloce") as GameObject;
    GameObject Mauro3 = Resources.Load("Mauro3_Veloce") as GameObject;
    GameObject Mauro4 = Resources.Load("Mauro4_Veloce") as GameObject;
    GameObject Mauro5 = Resources.Load("Mauro5_Veloce") as GameObject;
    GameObject Mauro6 = Resources.Load("Mauro6_Veloce") as GameObject;

    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 2f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 4f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 4f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 8f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 8f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 12f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 13f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 13f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 17f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 17f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 17f, 1));

    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 20f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 21f, 1));









  
   


}

void Update(){

}
}
