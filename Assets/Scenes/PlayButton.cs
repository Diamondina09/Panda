using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class PlayButton : MonoBehaviour

{

    public Button playButton; // Assign in Inspector



    void Start()

    {

        if (playButton != null)

        {

            playButton.onClick.AddListener(LoadScene);

        }

    }



    void LoadScene()

    {

        SceneManager.LoadScene("MainScene");

    }

}




