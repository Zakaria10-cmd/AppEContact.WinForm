using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEContact.WinForm.Models
{
   public static class DBContact
    {
        public static List<Contact>lstContacts;
        //Ajouter un contact à la liste des contacts
        public static int AddContact(Contact c)
        {
            if (lstContacts == null)
            {
                lstContacts = new List<Contact>();
            }
            c.Id = lstContacts.Any() ? lstContacts.Max(x => x.Id) + 1:100; //lambda expression
            lstContacts.Add(c);
            return c.Id;
        }
        //recuperer la liste des contacts
        public static List<Contact> GetListContact()
        {
            return lstContacts;
        }
        //supprimer un contact
        public static void DeleteContact(int idcontact)
        {
            int index = lstContacts.FindIndex(x => x.Id == idcontact);
            lstContacts.RemoveAt(index);
        }
        //// Modifier un Contact
        public static void UpdateContact(Contact c) 
        {
            Contact rech = lstContacts.FirstOrDefault(x => x.Id == c.Id);
            rech.NomComplet = c.NomComplet;
            rech.DateNaiss = c.DateNaiss;
            rech.Email = c.Email;
            rech.Tel = c.Tel;
            rech.Genre = c.Genre;
            rech.Photo = c.Photo;
        }
        // chercher un contact
        public static List<Contact> SearchContact(string name)
        {
            List<Contact> res = lstContacts.Where(x => x.NomComplet.ToLower().Contains(name.ToLower())).ToList();
            return res;
        }
    }
}
