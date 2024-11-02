using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationClass.ProjetUML
{
	public interface IGestionDesFilm
	{
		void AjouterFilm(Film Film);

		bool SupprimerFilm(Film film);

		List<Film> Rechercher(string critere);

		FilmDVD InformationListeFilm();
	}
}
