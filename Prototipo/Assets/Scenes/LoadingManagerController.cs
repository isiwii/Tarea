using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManagerController : MonoBehaviour
{
public string Nivel2;

void OnTriggerEnter(Collider other) {
    if(other.CompareTag("Player")){
        SceneManager.LoadScene(Nivel2);
       // SceneManager.SetActiveScene(SceneManager.GetSceneByName(Nivel2));
        }
    }

public void LoadScene(string cargar){
    SceneManager.LoadScene(cargar);
}
}
