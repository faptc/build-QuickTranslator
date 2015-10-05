using System;

namespace TranslatorEngine
{
	public class CharRange
	{
		private int startIndex;

		private int length;

		public int StartIndex
		{
			get
			{
				return this.startIndex;
			}
		}

		public int Length
		{
			get
			{
				return this.length;
			}
		}

		public CharRange(int startIndex, int length)
		{
			this.startIndex = startIndex;
			this.length = length;
		}

		public bool IsInRange(int index)
		{
			return this.startIndex <= index && index <= this.startIndex + this.length - 1;
		}

		public int GetEndIndex()
		{
			return this.startIndex + this.length - 1;
		}
	}
}
