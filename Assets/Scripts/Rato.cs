using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rato : MonoBehaviour
{

    private List<string> ordemCorreta = new List<string> {
        "RA",
        "TO"
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ra(Button button)
    {
        if (ordemCorreta.First() == "RA")
        {
            var colors = button.colors;
            colors.normalColor = Color.green;
            colors.highlightedColor = Color.green;
            colors.pressedColor = Color.green;
            colors.selectedColor = Color.green;
            colors.disabledColor = Color.green;
            button.colors = colors;

            ordemCorreta.Remove("RA");
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
                "RA",
                "TO"
            };
        }
    }


    public void To(Button button)
    {
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
            //Apresentar para trocar de nivel

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
                "RA",
                "TO"
            };
        }
    }


    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
