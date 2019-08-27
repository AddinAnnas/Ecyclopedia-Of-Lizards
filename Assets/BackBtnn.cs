using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtnn : MonoBehaviour
{
    public void BackBtn()
    {
        SceneManager.LoadScene("AnolesAndAgamids");
    }
    public void BackChameleon()
    {
        SceneManager.LoadScene("Chameleons");
    }
    public void BackIguana()
    {
        SceneManager.LoadScene("Iguanas");
    }
}
