using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class InstructionsButton : MonoBehaviour

{

    public Button instructionsButton; // Assign in Inspector



    void Start()

    {

        if (instructionsButton != null)

        {

            instructionsButton.onClick.AddListener(LoadInstructionsScene);

        }

    }



    void LoadInstructionsScene()

    {

        SceneManager.LoadScene("instructions");

    }

}




