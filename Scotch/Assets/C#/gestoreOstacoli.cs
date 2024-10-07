using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestoreOstacoli : MonoBehaviour
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
    GameObject Mauro1Veloce = Resources.Load("Mauro1_Veloce") as GameObject;
    GameObject Mauro2Veloce = Resources.Load("Mauro2_Veloce") as GameObject;
    GameObject Mauro3Veloce = Resources.Load("Mauro3_Veloce") as GameObject;
    GameObject Mauro4Veloce = Resources.Load("Mauro4_Veloce") as GameObject;
    GameObject Mauro5Veloce = Resources.Load("Mauro5_Veloce") as GameObject;
    GameObject Mauro6Veloce = Resources.Load("Mauro6_Veloce") as GameObject;
    GameObject Fire1 = Resources.Load("Fire1") as GameObject;
    GameObject Fire2 = Resources.Load("Fire2") as GameObject;

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 1f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 2f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 3f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 4f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 4f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 7f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 8f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 8f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 12f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 11f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 12f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 13f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 13f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 15f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 16f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 17f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 17f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 17f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 19f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 20f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 21f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 24f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 25f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 26f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 29f, 1));
    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 30f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 31f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 30f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 31f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 32f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 34f, 1));
    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 36f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 35f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 37f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 37f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 37f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 39f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 39f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 40f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 40f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 40f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 43f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 45f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 46f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 44f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 44f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 44f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 47f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 47f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 46f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 49f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 51f, 1));
    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 51f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 53f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 50f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 52f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 52f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 52f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 54f, 1));

    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 56f, 1));
    StartCoroutine(InstantiateWithDelay(Fire1, new Vector3(-16.38f, 0f, -5.96f), 57f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 59f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro1Veloce, new Vector3(-12.72f, 0.97f, -3.6f), 57f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 57f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro3Veloce, new Vector3(-12.72f, 0.97f, -7.86f), 57f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro2Veloce, new Vector3(-12.72f, 0.97f, -5.48f), 58f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 60f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 60f, 1));

    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 63f, 1));
    StartCoroutine(InstantiateWithDelay(Fire2, new Vector3(18.86f, 0f, -5.99f), 64f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 64f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 64f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 64f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro4Veloce, new Vector3(14.65f, 0.97f, -2.96f), 65f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro5Veloce, new Vector3(14.65f, 0.97f, -5.48f), 65f, 1));
    StartCoroutine(InstantiateWithDelay(Mauro6Veloce, new Vector3(14.65f, 0.97f, -7.86f), 65f, 1));
}

void Update()
{
if(Input.GetKeyDown("r")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
if(Input.GetKeyDown("1")) SceneManager.LoadScene("LevOne");
if(Input.GetKeyDown("2")) SceneManager.LoadScene("LevTwo");
if(Input.GetKeyDown("3")) SceneManager.LoadScene("LevThree");
}
}
