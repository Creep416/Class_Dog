using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Dog.Properties;

namespace Class_Dog
{
	[Serializable]
	internal class Dog
	{
		private string Dog_name;
		public Dog(string n) { Dog_name = n; }
		public string getDogName() { return Dog_name; }
		public void Dog_gav(Stream sound_stream) 
		{
			SoundPlayer sp = new SoundPlayer();
			sp.Stream = sound_stream;
            sp.Load();
			sp.Play();
		}
	}
}
