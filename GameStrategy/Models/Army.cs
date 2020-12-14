using System.Collections.Generic;
using GameStrategy.Models.ArmyUnit;

namespace GameStrategy.Models
{
    public class Army
    {
        public IList<Cavalry> Cavalries;
        public IList<Infantryman> Infantrymen;
        public IList<Recruit> Recruits;
        public IList<Shooter> Shooters;

        public Army()
        {
            Shooters = new List<Shooter>();
            Cavalries = new List<Cavalry>();
            Infantrymen = new List<Infantryman>();
            Recruits = new List<Recruit>();
            InBattleDay = 0;
            Earned = 0;
        }

        public int Earned { get; set; }
        public int InBattleDay { get; set; }
        public string ResultBattle { get; set; }

        public void RemoveAllArmy()
        {
            for (var i = 0; i < Cavalries.Count; i++) Cavalries.RemoveAt(i);

            for (var i = 0; i < Recruits.Count; i++) Recruits.RemoveAt(i);

            for (var i = 0; i < Infantrymen.Count; i++) Infantrymen.RemoveAt(i);

            for (var i = 0; i < Shooters.Count; i++) Shooters.RemoveAt(i);
        }

        #region Add

        public void AddCavalry(int count)
        {
            for (var i = 0; i < count; i++) Cavalries.Add(new Cavalry());
        }

        public void AddRecruit(int count)
        {
            for (var i = 0; i < count; i++) Recruits.Add(new Recruit());
        }

        public void AddShooter(int count)
        {
            for (var i = 0; i < count; i++) Shooters.Add(new Shooter());
        }

        public void AddInfantryman(int count)
        {
            for (var i = 0; i < count; i++) Infantrymen.Add(new Infantryman());
        }

        #endregion


        #region Remove

        public void RemoveCavalry(int count)
        {
            if (count >= Cavalries.Count)
                Cavalries.Clear();
            else
                for (var i = 0; i < count; i++)
                    Cavalries.RemoveAt(Cavalries.Count - 1);
        }

        public void RemoveRecruit(int count)
        {
            if (count >= Recruits.Count)
                Recruits.Clear();
            else
                for (var i = 0; i < count; i++)
                    Recruits.RemoveAt(Recruits.Count - 1);
        }

        public void RemoveShooter(int count)
        {
            if (count >= Shooters.Count)
                Shooters.Clear();
            else
                for (var i = 0; i < count; i++)
                    Shooters.RemoveAt(Shooters.Count - 1);
        }

        public void RemoveInfantryman(int count)
        {
            if (count >= Infantrymen.Count)
                Infantrymen.Clear();
            else

                for (var i = 0; i < count; i++)
                    Infantrymen.RemoveAt(Infantrymen.Count - 1);
        }


        #endregion

        public void ResetTimeTraining()
        {
            for (var i = 0; i < Recruits.Count; i++)
                if (Recruits[i].TimeTraining > 0)
                    Recruits[i].TimeTraining--;
            for (var i = 0; i < Cavalries.Count; i++)
                if (Cavalries[i].TimeTraining > 0)
                    Cavalries[i].TimeTraining--;
            for (var i = 0; i < Infantrymen.Count; i++)
                if (Infantrymen[i].TimeTraining > 0)
                    Infantrymen[i].TimeTraining--;
            for (var i = 0; i < Shooters.Count; i++)
                if (Shooters[i].TimeTraining > 0)
                    Shooters[i].TimeTraining--;
        }

        #region GetCountTrained

        public int GetCountTrainedRecruit()
        {
            var count = 0;
            for (var i = 0; i < Recruits.Count; i++)
                if (Recruits[i].TimeTraining == 0)
                    count++;
            return count;
        }

        public int GetCountTrainedCavalries()
        {
            var count = 0;
            for (var i = 0; i < Cavalries.Count; i++)
                if (Cavalries[i].TimeTraining == 0)
                    count++;
            return count;
        }

        public int GetCountTrainedInfantrymen()
        {
            var count = 0;
            for (var i = 0; i < Infantrymen.Count; i++)
                if (Infantrymen[i].TimeTraining == 0)
                    count++;
            return count;
        }

        public int GetCountTrainedShooters()
        {
            var count = 0;
            for (var i = 0; i < Shooters.Count; i++)
                if (Shooters[i].TimeTraining == 0)
                    count++;
            return count;
        }



        #endregion



    }
}