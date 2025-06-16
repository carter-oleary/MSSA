using Assignment11._1.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment11._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookContext _context;
        Book book = new Book();
        public MainWindow(BookContext bookContext)
        {
            InitializeComponent();
            _context = bookContext;
            LoadBooks();
            AddBookGrid.DataContext = book;
        }

        private void LoadBooks()
        {
            BookDG.ItemsSource = _context.Books.ToList();
        }

        Book selectedBook;
        private void UpdateBookForEdit(object sender, RoutedEventArgs e)
        {
            selectedBook = (sender as FrameworkElement).DataContext as Book;
            UpdateBookGrid.DataContext = selectedBook;
        }

        private void UpdateBook(object sender, RoutedEventArgs e)
        {
            _context.Update(selectedBook);
            _context.SaveChanges();
            LoadBooks();
            MessageBox.Show("Book updated successfully.");
        }

        private void DeleteBook(object sender, RoutedEventArgs e)
        {
            selectedBook = (sender as FrameworkElement).DataContext as Book;
            if (selectedBook != null)
            {
                _context.Books.Remove(selectedBook);
                _context.SaveChanges();
                LoadBooks();
                MessageBox.Show("Book deleted successfully.");
            }
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(book.Title) || string.IsNullOrWhiteSpace(book.Author) || book.PublishedYear <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }
            _context.Books.Add(book);
            _context.SaveChanges();
            LoadBooks();
            MessageBox.Show("Book added successfully.");
            book = new Book(); // Reset the book object
            AddBookGrid.DataContext = book; // Reset the DataContext
        }
    }
}