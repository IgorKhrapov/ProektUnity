using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{



    //������ ������ ������ ���� 
        public void StartScence()
    {
        Application.LoadLevel("dom");
    }


    //������ ������ �����
    public void Options(GameObject window)
    {
        window.SetActive(true);
    }

    //������ ������ ������
    public void Quit()
    {
        Application.Quit();
    }
}
