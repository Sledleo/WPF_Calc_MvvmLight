using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Calc_MvvmLight
{
    public class MyViewModel:ViewModelBase
    {
        public int X  { get; set; }
        public int Y  { get; set; }

        private int _z;

        public int Z
        {
            get { return _z; }
            set
            {
                _z = value;
                RaisePropertyChanged(() => Z);
            }
        }



        private ICommand _calc;

        public ICommand Calc
        {
            get
            {
                return _calc ?? ( _calc = new RelayCommand( ()=>
                {
                    Z = X + Y;
                }

                ));
            }
        }

        /*
        public MyViewModel()
        {
            X = 2;
            Y = 3;
            Z = X + Y;
        }
        */

    }
}
