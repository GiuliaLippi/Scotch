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
    GameObject Mauro1 = Resources.Load("Mauro1") as GameObject;
    GameObject Mauro2 = Resources.Load("Mauro2") as GameObject;
    GameObject Mauro3 = Resources.Load("Mauro3") as GameObject;
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(), 3f, 1));
   


}

void Update(){

}
}
