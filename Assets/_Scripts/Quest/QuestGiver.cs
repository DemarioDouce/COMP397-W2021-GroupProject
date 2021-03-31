using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public PlayerManger player;

    public GameObject questWindow;

    public void OpenQuestWindow() {
        Time.timeScale = 0;
        questWindow.SetActive(true);
    
    }

    public void AcceptQuest() {

        Time.timeScale = 1;
        questWindow.SetActive(false);
        quest.isActive = true;
        //Give to player
        player.quest = quest;
    }
}
