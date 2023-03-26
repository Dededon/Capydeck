using System;
﻿using DeckSwipe.Gamestate;

namespace DeckSwipe.CardModel {

	[Serializable]
	public class StatsModification {

		public int coal;
		public int food;
		public int health;
		public int hope;
		public int true_end = 0;

		public StatsModification(int coal, int food, int health, int hope, int true_end) {
			this.coal = coal;
			this.food = food;
			this.health = health;
			this.hope = hope;
			this.true_end = true_end;
		}

        public StatsModification(int coal, int food, int health, int hope)
        {
            this.coal = coal;
            this.food = food;
            this.health = health;
            this.hope = hope;
        }

        public void Perform() {
			// TODO Pass through status effects
			Stats.ApplyModification(this);
		}

	}

}
