using System.Windows.Forms;

namespace Polymorphism
{
	class Animal
	{
		private string _species;

		public Animal(string species)
		{
			_species = species;
		}

		public string Species
		{
			get { return _species; }
			set { _species = value; }
		}

		public virtual void MakeSound()
		{
			MessageBox.Show("Grrrrrrrrrr");
		}
	}
}
