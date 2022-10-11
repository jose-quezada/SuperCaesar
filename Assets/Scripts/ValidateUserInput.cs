using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ValidateUserInput : MonoBehaviour
{
    public Text NameBox, AgeBox;
    string nameText;
    byte edad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidateAge(){
        Debug.Log($" edad {AgeBox.text}");
        nameText =  NameBox.text;
        byte.TryParse(AgeBox.text, out edad);
        if(edad>=18){            
            SceneManager.LoadScene("Nivel0");
        }
        else{
            Debug.Log($"Error al ingresar edad {edad}");
        }
    }
}
