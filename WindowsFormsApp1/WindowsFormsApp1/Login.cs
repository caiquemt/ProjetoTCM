using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Login
    {
        //decalre properties 
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //intialise  
        public Login(string caique, string zxc)
        {
            this.Username = caique;
            this.Userpassword = zxc;
        }
     
        //validate string 
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //clear user inputs 
        private void ClearTexts(string caique, string zxc)
        {
            caique = String.Empty;
            zxc = String.Empty;
        }
        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string caique, string zxc)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(caique))
            {
                MessageBox.Show("Digite o usuário!");
                return false;

            }
            //check user name is valid type 
            else if (StringValidator(caique) == true)
            {
                MessageBox.Show("Apenas texto é permitido");
                ClearTexts(caique, zxc);
                return false;
            }
            //check user name is correct 
            else
            {
                if (Username != caique)
                {
                    MessageBox.Show("Usuário está incorreto.");
                    ClearTexts(caique, zxc);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(zxc))
                    {
                        MessageBox.Show("Digite a senha.");
                        return false;
                    }
                    //check password is correct 
                    else if (Userpassword != zxc)
                    {
                        MessageBox.Show("Senha incorreta.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}