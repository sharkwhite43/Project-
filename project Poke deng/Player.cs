﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Poke_deng
{
    public class Player
    {
        private List<Hand> handList;

        public string Name { get; private set; }
        public int Money { get; private set; }

        public int NumberOfHands => handList.Count;

        public Player(string name = "unknow", int money = 1000)
        {
            this.Name = name;
            this.Money = money;
            handList = new List<Hand>
            {
                new Hand(this)
            };
        }

        public bool NeedCard()
        {
            foreach (var hand in handList)
            {
                if (hand.Stay == false)
                {

                }
            }
            return false;
        }

        public void AddMoney(int amount)
        {
            Money += amount;
        }
        public void Deletemoney(int amount)
        {
            Money -= amount;
        }
        public void Samemoney(int amount)
        {
            Money = amount;
        }

        public void AddHand()
        {
            handList.Add(new Hand(this));
            setHandsName();
        }
        public void ResetHands()
        {
            foreach (var hand in handList)
            {
                hand.init();
            }
        }
        private void setHandsName()
        {
            uint index = 1;
            foreach (var hand in handList)
            {
                hand.Name = string.Format("{0}'s hand \"{1}\"", Name, index);
                index++;
            }
        }
        public Hand GetHand(int index)
        {
            if (index < 0 && index > NumberOfHands - 1)
            {
                return null;
            }
            return handList[index];
        }
        public Hand[] GetAllHand()
        {
            return handList.ToArray();
        }

        public override string ToString()
        {
            string returnText = string.Format("\n================= PLAYER DETAIL =================\n Name:{0}\n", Name);
            returnText += string.Format(" Balance: {0}\n", Money);
            returnText += string.Format(" Number of hands: {0}\n", NumberOfHands);
            returnText += "=================================================";
            return returnText;
        }

        public string Balance => string.Format("=================\n {0}'s Balance: {1}", Name, Money);

    }
}
