using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        ClanoviRepozitorij ClanoviRepozitorij = new ClanoviRepozitorij();

        public Member AddMember (string firstname, string surname)
        {
            bool isMember = ClanoviRepozitorij.IsMember(firstname, surname);

            if (isMember == false)
            {
                Member newMember = new Member ();

                newMember.firstname = firstname;
                newMember.surname = surname;

                ClanoviRepozitorij.SaveMember(newMember);

                return newMember;
            } 
            else 
            {
                return null;
            }
        }
    }
}
