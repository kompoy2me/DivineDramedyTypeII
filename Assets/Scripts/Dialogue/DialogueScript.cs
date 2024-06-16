using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    public Dialogue[] dialogue;
    int length = 80;

    public string first = "1";
    public string second = "2";
    public string third = "3";
    public string fourth = "4";

    void Start()
    {
        dialogue = new Dialogue[length];
        for (int i = 0; i < length; i++)
        {
            dialogue[i] = new Dialogue();
        }
        FillInLines();
    }

    void FillInLines() 
    {
        int n = 0;
        dialogue[n].char_name = first;
        dialogue[n].line = "��-���� ������� �����, ��������. ��� ����� ��� ����?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "�����, ���� ���. � �����, � ������, ���� �� ����� ���������������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� ����� ��� ����������. ����� �������, ����� ����� ������� ������?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "������� ����. ������, ������ ��� �� ������. ";
        dialogue[n].event_type = "pause";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��, " + second + ", ��� ���-�� � ������ �����, ������?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "���? �, ������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� ��� ���� �������.";
        dialogue[n].event_type = "pause";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "������ �����! � ����� �������������? ";
        dialogue[n].event_type = "add3char";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "������, ��� �����.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "�� ������ ���� � � ��� ������������? � �� ��� ���� ����, �������� �� ��������.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�������, � 1, � ��� 2.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "����������.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "� � 4, ������� �������������!";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "�� ������ ����? � ��� ����� ���� � ����� �������� ��������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��, ��� ������ �� ������� ��������� � ��������.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "��������? � ���� ��� ���-��?";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��, � ���� ��� ��� ���� "+ third +" �����, �� �� ...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "�� ������.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "���? ������? ��� ���?";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��, �� �� ����� ������, �� ������ ����� ������ ����� ������ ��� � ...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "�� �� ����� ������?";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� ��� ������, �� �����... �� ���������� �...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "� �� ����� ������ ���.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "����...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "�� ����� �� ������������? ���������� ���.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "���, �� ������� ��������, ������� ���� ��� �����. �� ������������, ��� �� ���� ��� ���� �� �����������, �� ��������.";
        dialogue[n].char_name = fourth;
        dialogue[n].line = "����...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "� �� 4?";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "� � �� �������. ������ � ����� ����� �������, �� ��� ������ ������ ��� ������� ���������, ������ � ��� ������ ��� ����� ����������. � ��� ������ ����. ����� ��� �������, ��� ����� �� ���������. ";
        n++;
        dialogue[n].char_name = "pause";
        dialogue[n].line = "...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "� �� ������� ���� ������� ��� ������. ����, ����� ����� �������������.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "��������, ����� ������ �������� ����� �����?";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "��, �� �� ����� �����. ������ ����������� ����.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "� ��� ��������� ��� ��������� �� ������������, ���� ��� ��� ���� ���������� �� ������ � ...";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "������ � ���, �� ��� �� ���� ������� � ����� �������� ���, � �� ���� ������, � ���-���� ����� �����, ������� ������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� ���, � ��� ����� ��� � ������� �����.";
        n++; 
        dialogue[n].char_name = first;
        dialogue[n].line = "�� �� ��� ������ ��� ���� �����.";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "� ���� �� � " + third + " �� ��������, ��� �� ���� �� ���? ";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "� ��� ��� ��...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� ������ ������ �� ����� ����, � �� ������ ��������� �������������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = third + " ��� �� ���� ������ ���������, ������ � ������ ��� ���������. ";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "�� ��� ���-�� ���������������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��������, " + fourth + ", ��� �������� �� �����.";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "�� ������� ���.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = second + ", ����...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "�� �������� " + third + " ���, � ����!";
        n++;
        dialogue[n].char_name = fourth;
        dialogue[n].line = "��� ������ ���������?";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "��� ����. �� �� ������...";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��� ��� ��� �� ������?! � ��� ���������...";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "� �� �����, ��� ��� ���������� ��� ���!";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� �� ���������� � ���, ��� " + third + " ����� ������! �� ������������, ��� �� �������, �� ��� �� ����! ";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "��� �� �������� ����! " +third+ " ��� ���� ������!";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "�� �������! �� ����� �� ���� �������!";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "�� ����� " + third +", �� ��� �������";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "��� �� ��� ��� ���� ��� ���������! �����, ��� ��������� ���� �� ����� ������!";
        n++;
        dialogue[n].char_name = second;
        dialogue[n].line = "�� ���� � ���!";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = "� ������ �������� � ������ ����: ���� �� ������ ����������� ����� �� " +third+ " ������ ��� ��� ��������� �����. ��� � ��������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = third + " ����� ������ ��� � ������. ������ ��� ����� �� ������.";
        n++;
        dialogue[n].char_name = first;
        dialogue[n].line = fourth + ", ������ �� � ���� � ����� �����, �����? ������ ������� �� �����.";
        Debug.Log(n);

    }


    public Dialogue[] GetDialogScript() 
    {
        return dialogue;
    }
}
