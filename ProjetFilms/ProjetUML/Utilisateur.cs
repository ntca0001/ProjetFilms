using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelisationClass.ProjetUML
{
	public abstract class Utilisateur
	{
		protected string nom;
		protected string email;
		protected string motDePasse;

		public string Nom
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

		public string Email
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

		public string MotDePasse
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

		public void AfficherProfil()
		{
			throw new NotImplementedException();
		}

		public abstract void SeConnecter();

		public abstract void SeDeConnecter();
	}
}
