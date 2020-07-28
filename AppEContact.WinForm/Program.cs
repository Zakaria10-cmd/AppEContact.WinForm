using AppEContact.WinForm.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEContact.WinForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmp = Properties.Resources._default;
            bmp.Save(ms, bmp.RawFormat);
            byte[] img = ms.ToArray();

            DBContact.AddContact(new Contact("Zakaria Oumar", DateTime.Parse("31/12/1978"), "zakari_oumarou@yahoo.fr","88 45 55 55", "M", img));
            DBContact.AddContact(new Contact("Diallo Aoudi", DateTime.Parse("31/12/1965"), "aoudi_06@yahoo.fr","91 05 01 74", "M", img));
            DBContact.AddContact(new Contact("Boubé Abdou", DateTime.Parse("01/01/1963"), "boube_abdou@yahoo.fr","96 59 42 12", "M", img));
            DBContact.AddContact(new Contact("Jamila Soumaila", DateTime.Parse("03/12/1982"), "jamilatou@yahoo.fr","94 45 65 25", "F", img));
            DBContact.AddContact(new Contact("Ibrahima Mahamad", DateTime.Parse("28/02/1983"), "ibrah@yahoo.fr","97 23 48 15", "M", img));
            DBContact.AddContact(new Contact("Marie Rose", DateTime.Parse("31/12/1979"), "marie@yahoo.fr","98 36 00 06", "F", img));
            DBContact.AddContact(new Contact("Doudou Aminatou", DateTime.Parse("03/12/1985"), "amina@yahoo.fr", "98 71 00 71", "F", img));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
