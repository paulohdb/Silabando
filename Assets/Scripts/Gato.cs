using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gato : MonoBehaviour
{
    // Start is called before the first frame update
    public Button nextButton;

    public GameObject audioGA;
    public GameObject audioTO;
    public GameObject audioGATO;

    public string level2;

    private List<string> ordemCorreta = new List<string> {
        "GA",
        "TO"
    };

    void Start()
    {
        nextButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Ga(Button button)
    {
        //implementar audio AQUI do GA


        if (ordemCorreta.First() == "GA")
        {
            var colors = button.colors;
            colors.normalColor = Color.green;
            colors.highlightedColor = Color.green;
            colors.pressedColor = Color.green;
            colors.selectedColor = Color.green;
            colors.disabledColor = Color.green;
            button.colors = colors;

            ordemCorreta.Remove("GA");
        }
        else
        {
            var colors = button.colors;
            colors.normalColor = Color.red;
            colors.highlightedColor = Color.red;
            colors.pressedColor = Color.red;
            colors.selectedColor = Color.red;
            colors.disabledColor = Color.red;
            button.colors = colors;

            ordemCorreta = new List<string> {
                "GA",
                "TO"
            };
        }
    }


    public void To(Button button)
    {
        //implementar audio AQUI do TO


        Debug.Log("cliquei no TO!!!");

        if (ordemCorreta.First() == "TO")
        {
            var colors = button.colors;
            colors.normalColor = Color.green;
            colors.highlightedColor = Color.green;
            colors.pressedColor = Color.green;
            colors.selectedColor = Color.green;
            colors.disabledColor = Color.green;
            button.colors = colors;

            ordemCorreta.Remove("TO");
            //TODO - Emitir a palavra inteira

            nextButton.gameObject.SetActive(true);
        }
        else
        {
            var colors = button.colors;
            colors.normalColor = Color.red;
            colors.highlightedColor = Color.red;
            colors.pressedColor = Color.red;
            colors.selectedColor = Color.red;
            colors.disabledColor = Color.red;
            button.colors = colors;

            ordemCorreta = new List<string> {
                "GA",
                "TO"
            };
        }
    }




    public void NextLevel()
    {
        SceneManager.LoadScene(level2);
    }
}
