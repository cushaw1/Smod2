﻿namespace Smod2.Game
{
	public enum ItemType
	{
		JANITOR_KEYCARD = 0 // CBF right now
	}

	public abstract class Item
	{
		public abstract bool InWorld { get; }
		public abstract ItemType ItemType { get; }
		public abstract void Remove();
	}
}
