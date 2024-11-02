using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationClass.ProjetUML
{
	public abstract class Film
	{
		public string titreFilm;
		public string realisateur;
		public string genre;
		public int dateDeSortie;
		public decimal noteImdb;

		public string TitreFilm
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string realisateur
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string Genre
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string DateDeSortie
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int NoteImdb
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public void InformationFilm()
		{
			throw new NotImplementedException();
		}

		public abstract string BandeAnnonce();
	}
}
