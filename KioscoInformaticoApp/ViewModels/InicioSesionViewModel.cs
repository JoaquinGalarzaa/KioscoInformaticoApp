using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KioscoInformaticoApp.Claes;

namespace KioscoInformaticoApp.ViewModels
{
    public class InicioSesionViewModel : ObjectNotification
    {
		private string email;
		public string Email
		{
			get { return email; }
			set { email = value;
				OnPropertyChanged();
			}
		}

		private string password;
		public string Password
		{
			get { return password; }
			set { password = value;
                OnPropertyChanged();
            }
		}

		private bool recordarContraseña;

		public bool RecordarContraseña
		{
			get { return recordarContraseña; }
			set { recordarContraseña = value;
                OnPropertyChanged();
            }
		}


	}
}
