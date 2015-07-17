using System;

namespace TestMultiPlatform
{
	public class SharedInt
	{
        public int sharedInt = 0;

		public SharedInt ()
		{
            sharedInt = 1;
		}

        public void IncrementInt() {
            sharedInt += 1;
        }
	}
}

