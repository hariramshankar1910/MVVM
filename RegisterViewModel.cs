using StoreMVVM.Helper;
using StoreMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;
using StoreMVVM.Converter;

namespace StoreMVVM.View_Model
{
    public class RegisterViewModel:Student
    {
        public RelayCommand RegisterCommand { get; set; }
       

        public RelayCommand SearchCommand { get; set; }
        public ObservableCollection<Student> SearchList { get; set; }
        private string _searchuser;
        public string SearchUser
        {
            get { return _searchuser; }
            set
            {
                _searchuser = value;
                OnProperty();
            }
        }

        private Student _student;


        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }



        public ObservableCollection<Student> StudentList
        {
            get; set;
        }
        public RegisterViewModel()
        {

            RegisterCommand = new RelayCommand(RegisterData);
           
            SearchCommand = new RelayCommand(SearchData);
            if (Student == null)
            {
                Student = new Student();
            }
            if (StudentList == null)
            {
                StudentList = new ObservableCollection<Student>();
            }
            if (SearchList == null)
            {
                SearchList = new ObservableCollection<Student>();
            }

            Student.Gender = "M";

            Student.Gender = "F";


            isGenShow = true;



        }
        public void RegisterData()
        {
            StudentList.Add(new Student { Name = Student.Name, Age = Student.Age, Salary = Student.Salary, Gender = Student.Gender });

        }
        public void SearchData()
        {


            SearchList.Clear();
            foreach (Student user in StudentList)
            {
                if (user.Name.ToLower().Contains(SearchUser.ToLower()))
                {
                    SearchList.Add(user);
                }
            }
    }   }
}
