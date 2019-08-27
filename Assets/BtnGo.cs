using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnGo : MonoBehaviour {

	public void ChameleonGo()
	{
		SceneManager.LoadScene ("Chameleons");
	}
	public void IguanaGo()
	{
		SceneManager.LoadScene ("Iguanas");
	}
	public void AnalosAndGO()
	{
		SceneManager.LoadScene ("AnolesAndAgamids");
	}
	public void BackBtn()
	{
		SceneManager.LoadScene ("Menu");
	}

}
