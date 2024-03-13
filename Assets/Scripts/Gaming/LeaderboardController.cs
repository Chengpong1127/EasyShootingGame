using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Ling;

public class LeaderboardController : MonoBehaviour
{
    private List<PlayerScore> scores = new List<PlayerScore>();

    public void AddNewScore(string name, int score)
    {
        // �ˬd�ˬd�ӦW�٬O�_�w�g�s�b��Ʀ�]��
        if (!NameExists(name))
        {
            scores.Add(new PlayerScore(name, score));

            // ����ƶi��Ƨ�
            scores = scores.OrderByDescending(s => s.score).ToList();
        }
        else //�p�G�W�l�s�b�A�|��s�ƭ�
        {   
            var existingScore = scores.Find(s => s.name == name);
            if (score > existingScore.score)
            {
                existingScore.score = score;
            }
         }

    }   

    public bool NameExists(string name)
    {
        return scores.Any(s => s.name == name);
    }


