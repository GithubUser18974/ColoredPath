using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour {

	public void Retry1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
