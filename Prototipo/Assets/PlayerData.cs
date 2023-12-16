using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour {

    //variables para guardar despues
    private int coins;
    private int boxes;
    private string level;
    public static bool Load = false;

    void Awake() 
{
    DontDestroyOnLoad(transform.gameObject);
}

    //esta funcion se llama automaticamente cuando se cierra el juego
    void OnApplicationQuit() {
        SaveGame();
    }

    public void SaveGame() {
        //se obtiene los datos que se quiere guardar
        //en este caso coins, boxes y el nombre del nivel
        //also esto puede estar malo porque no me acuerdo del nombre de los archivos
        coins = CoinCollected.coins;
        boxes = BoxCollected.Boxes;
        level = SceneManager.GetActiveScene().name;
        //se guardan los valores
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("boxes", boxes);
        PlayerPrefs.GetString("level", level);

        PlayerPrefs.Save();
    }

    //asignar este a boton de continuar en el menu
    //si el jugador no tiene nada guardado, se comienza como si fuera un new game
    public void LoadGame() {
          Load = true;
          //se carga el nivel donde estaba el jugador
          SceneManager.LoadScene(PlayerPrefs.GetString("level", "Nivel1"));
          //se carga la cantidad de coleccionables que tenia
          CoinCollected.coins = PlayerPrefs.GetInt("coins", 2);
          BoxCollected.Boxes = PlayerPrefs.GetInt("boxes", 3);
    }

}