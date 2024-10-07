using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestoreostacoli_livelloTre : MonoBehaviour
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
    GameObject SferaLenta1 = Resources.Load("Sfera1_Lenta") as GameObject;
    GameObject SferaLenta2 = Resources.Load("Sfera2_Lenta") as GameObject;
    GameObject SferaLenta3 = Resources.Load("Sfera3_Lenta") as GameObject;
    GameObject SferaLenta4 = Resources.Load("Sfera4_Lenta") as GameObject;
    GameObject Smoke1 = Resources.Load("Smoke1") as GameObject;
    GameObject Smoke2 = Resources.Load("Smoke2") as GameObject;
    GameObject Smoke3 = Resources.Load("Smoke3") as GameObject;
    GameObject Smoke4 = Resources.Load("Smoke4") as GameObject;
  

    StartCoroutine(InstantiateWithDelay(Smoke1, new Vector3(-4.5f, 5f, -0.48f), 1f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta1, new Vector3(-4.51f, 2.81f, -0.51f), 2f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke3, new Vector3(3.099f, 5f, -0.5f), 4f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta3, new Vector3(3.17f, 2.81f, -0.68f), 5f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke2, new Vector3(-0.93f, 5f, -0.55f), 7f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke4, new Vector3(6.43f, 5f, -0.617f), 7f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta4, new Vector3(6.72f, 2.81f, -0.6f), 8f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta2, new Vector3(-0.94f, 2.81f, -0.65f), 8f, 1));
    
    StartCoroutine(InstantiateWithDelay(Smoke1, new Vector3(-4.5f, 5f, -0.48f), 10f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke2, new Vector3(-0.93f, 5f, -0.55f), 10f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta2, new Vector3(-0.94f, 2.81f, -0.65f), 11f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta1, new Vector3(-4.51f, 2.81f, -0.51f), 11f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke4, new Vector3(6.43f, 5f, -0.617f), 13f, 1));  
    StartCoroutine(InstantiateWithDelay(SferaLenta4, new Vector3(6.72f, 2.81f, -0.6f), 14f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke1, new Vector3(-4.5f, 5f, -0.48f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke3, new Vector3(3.099f, 5f, -0.5f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta1, new Vector3(-4.51f, 2.81f, -0.51f), 17f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta3, new Vector3(3.17f, 2.81f, -0.68f), 17f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke2, new Vector3(-0.93f, 5f, -0.55f), 17f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta2, new Vector3(-0.94f, 2.81f, -0.65f), 18f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke3, new Vector3(3.099f, 5f, -0.5f), 19f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke4, new Vector3(6.43f, 5f, -0.617f), 18f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta3, new Vector3(3.17f, 2.81f, -0.68f), 20f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta4, new Vector3(6.72f, 2.81f, -0.6f), 19f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke1, new Vector3(-4.5f, 5f, -0.48f), 21f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke2, new Vector3(-0.93f, 5f, -0.55f), 22f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke3, new Vector3(3.099f, 5f, -0.5f), 23f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta1, new Vector3(-4.51f, 2.81f, -0.51f), 22f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta2, new Vector3(-0.94f, 2.81f, -0.65f), 23f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta3, new Vector3(3.17f, 2.81f, -0.68f), 24f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke1, new Vector3(-4.5f, 5f, -0.48f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Smoke4, new Vector3(6.43f, 5f, -0.617f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta4, new Vector3(6.72f, 2.81f, -0.6f), 26f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta1, new Vector3(-4.51f, 2.81f, -0.51f), 26f, 1));

    StartCoroutine(InstantiateWithDelay(Smoke2, new Vector3(-0.93f, 5f, -0.55f), 27f, 1));  
    StartCoroutine(InstantiateWithDelay(Smoke3, new Vector3(3.099f, 5f, -0.5f), 27f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta2, new Vector3(-0.94f, 2.81f, -0.65f), 28f, 1));
    StartCoroutine(InstantiateWithDelay(SferaLenta3, new Vector3(3.17f, 2.81f, -0.68f), 28f, 1));




    

    










}

void Update() 
{

}
}
