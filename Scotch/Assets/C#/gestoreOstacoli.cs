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
    GameObject Mauro1 = Resources.Load("Mauro I") as GameObject;
    GameObject Mauro2 = Resources.Load("Mauro II") as GameObject;
    GameObject Mauro3 = Resources.Load("Mauro III") as GameObject;
    GameObject Mauro4 = Resources.Load("Mauro IV") as GameObject;
    GameObject Mauro5 = Resources.Load("Mauro V") as GameObject;
    GameObject Mauro6 = Resources.Load("Mauro VI") as GameObject;
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-13.34f, 0.97f, -3.6f), 3f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.97f, 0.97f, -5.21f), 5f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.91f, 0.97f, -7.57f), 3f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -3.6f), 8f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(12.84f, 0.97f, -5.21f), 10f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(13.53f, 0.97f, -7.57f), 8f, 1));
   


}

void Update(){

}
}
