using StoreMVVM.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreMVVM.View_Model;

namespace StoreMVVM.Model
{
    public class Student : Notify
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnProperty();
            }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnProperty();
            }
        }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnProperty();
            }
        }


        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnProperty();
            }
        }
        private bool _isGenShow;

        public bool isGenShow
        {
            get { return _isGenShow; }
            set
            {
                _isGenShow = value;
                OnProperty();
            }


        }
    }
}