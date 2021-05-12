using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsController : MonoBehaviour
{
    [SerializeField] private GameObject[] tools;

    private int selectedToolNumber = 1;

    void Start()
    {
        //������������� ���������� �� ���������
        ChangeTools(selectedToolNumber);
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            ToolNextSelect();
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            ToolPreviousSelect();
        }
    }

    public void OnClickLeftButton()
    {
        ToolPreviousSelect();
    }

    public void OnClickRightButton()
    {
        ToolNextSelect();
    }

    /// <summary>
    /// ��������� ����� ���������� ����������� � ���������. ���� ��������� ������ - �������� ���������
    /// </summary>
    private void ToolNextSelect()
    {
        if (selectedToolNumber != 4) selectedToolNumber++;
        else selectedToolNumber = 1;
        ChangeTools(selectedToolNumber);
        Debug.Log("++" + selectedToolNumber);
    }

    /// <summary>
    /// ����������� ����� ���������� ����������� � ���������. ���� ����������� ������ - �������� ������
    /// </summary>
    private void ToolPreviousSelect()
    {
        if (selectedToolNumber != 1) selectedToolNumber--;
        else selectedToolNumber = 4;
        ChangeTools(selectedToolNumber);
        Debug.Log("--" + selectedToolNumber);
    }


    /// <summary>
    /// �������� �������� �� ������� ������������, �������� ������ ���������� �����������
    /// </summary>
    /// <param name="numberOfTool"></param>
    public void ChangeTools(int numberOfTool)
    {
        for (int i = 0; i < tools.Length; i++)
        {
            tools[i].SetActive(false);
        }
        switch (numberOfTool)
        {
            case 1: 
                {
                    tools[0].SetActive(true);
                    tools[1].SetActive(true);
                    break;
                }
            case 2:
                {
                    tools[2].SetActive(true);                    
                    break;
                }
            case 3:
                {
                    tools[3].SetActive(true);
                    break;
                }
            case 4:
                {
                    tools[4].SetActive(true);
                    tools[5].SetActive(true);
                    break;
                }
        }
    }
}
