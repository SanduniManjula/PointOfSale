using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sale_System
{
     public partial class User_WindowVM :ObservableObject
    {


        [ObservableProperty]
        public int companyId;

        [ObservableProperty]
        public string firstName;

        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        ObservableCollection<User> users;


        [RelayCommand]
        public void InsertUser()
        {
            User p = new User()
            {
                CompanyId = CompanyId,
                FirstName = FirstName,
                LastName = LastName,
                UserName = UserName,
                Password = Password

            };
            try
            {
                using (var db = new DataBaseContext())
                {
                    db.User_Database.Add(p);
                    db.SaveChanges();
                }
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !");
            }

        }
        public void LoadUser()
        {
            using (var db = new DataBaseContext())
            {
                var list = db.User_Database
                .OrderBy(p => p.CompanyId)
                .ToList();
                Users = new ObservableCollection<User>(list);
            }
        }

        [RelayCommand]
        public void DeleteUser(User p)
        {
            try
            {
                using (var db = new DataBaseContext())
                {
                    var selectedUser = db.User_Database.Where(r => r.CompanyId == p.CompanyId);
                    foreach (var user in selectedUser)
                    {
                        db.User_Database.Remove(user);
                    }
                    db.SaveChanges();
                }
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !");
            }
            
        }


        public void EditUser(User p)
        {
            try
            {
                using (var db = new DataBaseContext())
                {
                    if (CompanyId != p.CompanyId)
                    {
                        DeleteUser(p);
                        InsertUser();
                    }
                    else
                    {
                        p.CompanyId = CompanyId;
                        p.FirstName = FirstName;
                        p.LastName = LastName;
                        p.UserName = UserName;
                        p.Password = Password;

                        db.User_Database.Update(p);
                        db.SaveChanges();

                    }


                }
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !");
            }
            
        }



        public User_WindowVM()
        {
            LoadUser();

        }
    }
}



