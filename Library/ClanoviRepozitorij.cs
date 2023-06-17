using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal class ClanoviRepozitorij
    {
        public List<Member> MembersList { get; set; } = new List<Member>();

        public bool IsMember (string firstname, string surname)
        {
            bool isMember = false;

            foreach (Member member in MembersList) 
            {
                if (member.firstname == firstname && member.surname == surname) 
                { 
                    isMember = true; 
                }
            }

            return isMember;
        }

        public void SaveMember(Member newMember)
        {
            newMember.username = GenerateUsername(newMember);

            newMember.password = GeneratePassword();

            MembersList.Add(newMember);
        }

        private string GenerateUsername(Member newMember)
        {
            int maxLenght = 8;
            int minLenght = 4;

            string username = newMember.firstname.Substring(0,1) + newMember.surname;

            int usernameLenght = username.Length;

            if (usernameLenght < minLenght) 
            {
                int numberOfMissingChars = minLenght - usernameLenght;

                Random randomNumber = new Random();

                for (int counter = 0; counter < numberOfMissingChars; counter++)
                {
                    username += randomNumber.Next(0, 9);
                }
            }
            else if (usernameLenght > maxLenght) 
            {
                username = username.Substring(0, 8);
            }

            username = username.ToLower();

            return username;
        }

        private string GeneratePassword()
        {
            Random randomNumber = new Random();

            return randomNumber.Next(1000, 9999).ToString();
        }
    }
}
