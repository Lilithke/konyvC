using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINTAVIZSGAC
{
    public partial class Form1 : Form
    {
        private BookService bookService;
        public Form1()
        {
            InitializeComponent();
            BooksGrid.AutoGenerateColumns = false;
        }

        

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (BooksGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Törléshez előbb válaszon ki egy könyvet!");
                return;
            }
            DialogResult result = MessageBox.Show("Biztos szeretné törölni a kiválasztott könyvet?", "Biztos", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Book selected = BooksGrid.SelectedRows[0].DataBoundItem as Book;
                if (bookService.DeleteBook(selected.Id))
                {
                    MessageBox.Show("Sikeres törlés!");
                }
                else
                {
                    MessageBox.Show("A könyv korábban törlésrekerült", "Hiba történt a törlés során");
                }
                RefreshBookGrids();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Hiba történt a törlés során");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bookService = new BookService();
                RefreshBookGrids();

            }catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message,"Hiba történt az adatbázis kapcsolat kialakításakor.");
                this.Close();
            }
        }

        private void RefreshBookGrids()
        {
           
            BooksGrid.DataSource = bookService.GetBooks();
            BooksGrid.ClearSelection();
        }

        
    }
}
