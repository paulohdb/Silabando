using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> ordemCorreta;
    public static GameManager Instance;
    private bool ganhou;
    public GameObject imagemGanhou;

    public void Verifica(GameObject buttonGameObject)
    {
        if(ganhou)
            return;
        if (ordemCorreta.First().Equals(buttonGameObject))
        {
            var button = buttonGameObject.GetComponent<Button>();
            var colors = button.colors;
            colors.normalColor = Color.green;
            colors.highlightedColor = Color.green;
            colors.pressedColor = Color.green;
            colors.selectedColor = Color.green;
            colors.disabledColor = Color.green;
            button.colors = colors;
            button.interactable = false;
            ordemCorreta.RemoveAt(0);
            ganhou = ordemCorreta.Count == 0;
            if(imagemGanhou != null)
                imagemGanhou.SetActive(ganhou);
        }

        else
        {
            var button = buttonGameObject.GetComponent<Button>();
            var colors = button.colors;
            StartCoroutine(Release(button, colors));
            colors.normalColor = Color.red;
            colors.highlightedColor = Color.red;
            colors.pressedColor = Color.red;
            colors.selectedColor = Color.red;
            colors.disabledColor = Color.red;
            button.colors = colors;
            


        }
    }

    private IEnumerator Release(Button button, ColorBlock colors)
    {
        yield return new WaitForSeconds(1f);
        button.colors = colors;
    }
    



    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
