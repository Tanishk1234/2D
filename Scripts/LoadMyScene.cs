
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadMyScene : MonoBehaviour
{
    public void LoadScene(int LoadMyLevel)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LoadMyLevel);
    }
}
