using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<GameObject> ordemCorreta;
    public static GameManager Instance;
    public GameObject imagemGanhou;
    public Text silabasText;

    private bool ganhou;
    private int silabasStringOffset = 0;
    private StringBuilder silabasString;

    public void Start()
    {
        silabasString = new StringBuilder("");

        if (silabasText)
        {
            foreach(GameObject button in ordemCorreta)
            {
                silabasString.Append('_', button.GetComponentInChildren<Text>().text.Length);
                silabasString.Append('-');
            }

        }
        silabasString.Remove(silabasString.Length - 1, 1);
        silabasText.text = silabasString.ToString();
    }

    private void addSilaba(string silaba)
    {

        silabasString.Replace(silabasString.ToString(silabasStringOffset, silaba.Length), silaba, silabasStringOffset, silaba.Length);
        silabasStringOffset += silaba.Length + 1;
        silabasText.text = silabasString.ToString();
    }

    public void Verifica(GameObject buttonGameObject)
    {
        if(ganhou)
            return;

        var button = buttonGameObject.GetComponent<Button>();
        var colors = button.colors;

        if (ordemCorreta.First().Equals(buttonGameObject))
        {
            
            colors.normalColor = Color.green;
            colors.highlightedColor = Color.green;
            colors.pressedColor = Color.green;
            colors.selectedColor = Color.green;
            colors.disabledColor = Color.green;
            button.colors = colors;
            button.interactable = false;
            ordemCorreta.RemoveAt(0);
            ganhou = ordemCorreta.Count == 0;
            addSilaba(button.GetComponentInChildren<Text>().text);

            if (imagemGanhou != null)
                imagemGanhou.SetActive(ganhou);
        }

        else
        {
            StartCoroutine(Release(button, colors));
            colors.normalColor = Color.red;
            colors.highlightedColor = Color.red;
            colors.pressedColor = Color.red;
            colors.selectedColor = Color.red;
            colors.disabledColor = Color.red;
            button.colors = colors;
            button.interactable = false;
        }
    }

    private IEnumerator Release(Button button, ColorBlock colors)
    {
        yield return new WaitForSeconds(1f);
        button.interactable = true;
        button.colors = colors;
    }
    



    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
