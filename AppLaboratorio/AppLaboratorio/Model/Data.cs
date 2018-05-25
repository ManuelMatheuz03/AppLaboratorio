using AppLaboratorio.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
namespace AppLaboratorio.Model
{
    public class Data : Notificable
    {
        private ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
        public ObservableCollection<Aprendiz> Aprendices
        {
            get { return aprendices; }
            set
            {
                if (aprendices == value)
                {
                    return;
                }
                aprendices = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }
    }
}
