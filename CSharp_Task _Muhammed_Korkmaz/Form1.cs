using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Task__Muhammed_Korkmaz
{
    public partial class Form1 : Form
    {
        private List<Book> m_BookList;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "CSV files |*.csv";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                file.CheckFileExists = false;
                file.Title = "Select the csv file..";
                file.ShowDialog();

                string path = file.FileName;

                ReadCsvFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadCsvFile(string path)
        {
            var BooksFromCsv = from row in File.ReadLines(@path).Skip(1).Where(arg => !string.IsNullOrWhiteSpace(arg) && arg.Length > 0).AsEnumerable()
                               let column = row.Split(';')
                               select new Book
                               {
                                   Title = column[0],
                                   Author = column[1],
                                   Year = column[2],
                                   Price = Convert.ToDecimal(column[3]),
                                   InStock = Convert.ToString(column[4]) == "yes",
                                   Binding = column[5],
                                   Description = column[6]
                               };

            m_BookList = BooksFromCsv.OrderBy(item => item.Price).ToList();

            // Create binding list
            var bindings = m_BookList.Select(item => item.Binding).Distinct().ToList();
            List<Bindings> bindingList = new List<Bindings>();
            foreach (var item in bindings)
            {
                bindingList.Add(new Bindings()
                {
                    Binding = item
                });
            }
            bdgvBindingList.DataSource = bindingList;

            dgvBookList.DataSource = m_BookList;
            ChangeOutOfStockColor();
        }

        // Rows with books, that are not in stock shall be highlighted
        private void ChangeOutOfStockColor()
        {
            foreach (DataGridViewRow row in dgvBookList.Rows)
            {
                if (!Convert.ToBoolean(row.Cells[4].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        // Deletes all books from book list, that are not in stock
        private void btnDeleteBooksOutOfStock_Click(object sender, EventArgs e)
        {
            m_BookList = m_BookList.Where(item => item.InStock).ToList();
            dgvBookList.DataSource = m_BookList;
        }

        // Color gradient from highest to lowest price
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvBookList.Rows)
            {
                int colorValue = Convert.ToInt32(Myrow.Cells[3].Value);
                if (colorValue > 250)
                {
                    colorValue = 250;
                }

                Myrow.Cells[3].Style.BackColor = Color.FromArgb(colorValue, 150, 150); ;
            }
        }

        // Show the description
        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                try
                {
                    var book = m_BookList[e.RowIndex];
                    MessageBox.Show(Convert.ToString(book.Description), Convert.ToString(book.Title));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
