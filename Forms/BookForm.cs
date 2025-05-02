using System;
using System.Linq;
using System.Windows.Forms;
using PersonalInterestApp.Models;

namespace PersonalInterestApp.Forms
{
    public partial class BookForm : Form
    {
        private System.Collections.Generic.List<Book> bookList;

        public BookForm()
        {
            InitializeComponent();
            bookList = DataStore<Book>.Load("books");
            UpdateBookList();
        }

        private void UpdateBookList()
        {
            lstBooks.Items.Clear();
            foreach (var book in bookList)
            {
                lstBooks.Items.Add($"{book.Title} by {book.Author} ({book.Year})");
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new Book
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Genre = txtGenre.Text,
                    Year = int.Parse(txtYear.Text)
                };
                bookList.Add(book);
                DataStore<Book>.Save(bookList, "books");
                UpdateBookList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                var selectedBook = lstBooks.SelectedItem.ToString();
                var bookToDelete = bookList.FirstOrDefault(b => selectedBook.Contains(b.Title));
                if (bookToDelete != null)
                {
                    bookList.Remove(bookToDelete);
                    DataStore<Book>.Save(bookList, "books");
                    UpdateBookList();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearInputs()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
        }
    }
}