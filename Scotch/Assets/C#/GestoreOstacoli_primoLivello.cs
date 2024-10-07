using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestoreOstacoli_primoLivello : MonoBehaviour
{
  IEnumerator InstantiateWithDelay(GameObject prefab, Vector3 position, float delay, int amount)
{
    for(int i = 1 ; i <= amount;i++)
    {
        yield return new WaitForSeconds(delay);
        
        if (prefab.name.Contains("Fire"))
        {
          GameObject target;
          target = Object.Instantiate(prefab, position, Quaternion.identity);
          StartCoroutine (DestroyWithDelay( target , 1f));
        }
        
        else
        Object.Instantiate(prefab, position, Quaternion.identity);


    }
}

IEnumerator DestroyWithDelay (GameObject target, float delay)
{
    yield return new WaitForSeconds(delay);
    Debug.Log(target.name+" Distrutto");
    Destroy(target);
}

void Start()
{
    GameObject Mauro1 = Resources.Load("Mauro I") as GameObject;
    GameObject Mauro2 = Resources.Load("Mauro II") as GameObject;
    GameObject Mauro3 = Resources.Load("Mauro III") as GameObject;
    GameObject Mauro4 = Resources.Load("Mauro IV") as GameObject;
    GameObject Mauro5 = Resources.Load("Mauro V") as GameObject;
    GameObject Mauro6 = Resources.Load("Mauro VI") as GameObject;
    GameObject Fire1 = Resources.Load("Fire1") as GameObject;
    GameObject Fire2 = Resources.Load("Fire2") as GameObject;

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 1f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 2f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 6f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 6f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 7f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 7f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 10f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 11f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 11f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 15f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 14f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 15f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 18f, 1));
    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 24f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 18f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 24f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 19f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 19f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 20f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 25f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 28f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 29f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3, new Vector3(-12.72f, 0.97f, -7.86f), 29f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 30f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 30f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 34f, 1)); 
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 34f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 35f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 39f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 40f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 40f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 44f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4, new Vector3(14.65f, 0.97f, -2.96f), 45f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5, new Vector3(14.65f, 0.97f, -5.48f), 45f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 45f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 49f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 51f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1, new Vector3(-12.72f, 0.97f, -3.6f), 50f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2, new Vector3(-12.72f, 0.97f, -5.48f), 51f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6, new Vector3(14.65f, 0.97f, -7.86f), 52f, 1));










}

void Update()
{
if(Input.GetKeyDown("r")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
if(Input.GetKeyDown("1")) SceneManager.LoadScene("LevOne");
if(Input.GetKeyDown("2")) SceneManager.LoadScene("LevTwo");
if(Input.GetKeyDown("3")) SceneManager.LoadScene("LevThree");
}
}
