using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterExit : MonoBehaviour {
          
    

	public void EnterBtn()
	{
		SceneManager.LoadScene ("List");
	}
	public void QuitBtn()
	{
		
		Application.Quit ();
	}


	
}
