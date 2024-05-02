#include <iostream>
#include <vector>
#include <string>
using namespace std;

// Класс Книга
class Book {
public:
    Book(const string& title, int publicationYear, int totalPages, const string& author, const string& category)
        : title_(title), publicationYear_(publicationYear), totalPages_(totalPages), author_(author), category_(category) {}

    bool operator==(const Book& other) const {
        return title_ == other.title_;
    }

    string getTitle() const { return title_; }
    int getPublicationYear() const { return publicationYear_; }
    int getTotalPages() const { return totalPages_; }
    string getAuthor() const { return author_; }
    string getCategory() const { return category_; }

    string getBookInfo() const {
        return "Название: " + title_ + ", Автор: " + author_ + ", Год издания: " + to_string(publicationYear_);
    }

private:
    string title_;
    int publicationYear_;
    int totalPages_;
    string author_;
    string category_;
};

// Класс Категория
class Category {
public:
    Category(const string& name) : name_(name) {}

    string getCategoryName() const { return name_; }

private:
    string name_;
};

// Класс Автор
class Author {
public:
    Author(const string& firstName, const string& lastName)
        : firstName_(firstName), lastName_(lastName) {}

    string getAuthorInfo() const { return firstName_ + " " + lastName_; }

private:
    string firstName_;
    string lastName_;
};

// Класс Читатель
class Reader {
public:
    Reader(const string& firstName, const string& lastName, int registrationNumber, const string& email, const string& password)
        : firstName_(firstName), lastName_(lastName), registrationNumber_(registrationNumber), email_(email), password_(password) {}

    void extendReturnDeadline(const Book& book) {
        // Логика продления срока возврата
        cout << "Читатель " << firstName_ << " продлил срок возврата для книги \"" << book.getTitle() << "\"" << endl;
    }

    void registerReader(const string& firstName, const string& lastName, const string& email, const string& password) {
        // Логика регистрации читателя
        cout << "Читатель " << firstName << " зарегистрирован с почтой \"" << email << "\" и паролем \"" << password << "\"" << endl;
    }

    int getRegistrationNumber() const {
        return registrationNumber_;
    }

    string getName() const { return firstName_ + " " + lastName_; }

    void selectBook(const Book& book) {
        selectedBooks_.push_back(book);
        cout << "Читатель " << firstName_ << " выбрал книгу \"" << book.getTitle() << "\"" << endl;
    }

    vector<Book> getSelectedBooks() const {
        return selectedBooks_;
    }

    string getEmail() const { return email_; }
    string getPassword() const { return password_; }


private:
    string firstName_;
    string lastName_;
    int registrationNumber_;
    string email_;
    string password_;
    vector<Book> selectedBooks_; // Список выбранных книг

    //void returnBook(const Book& book) {
    //    // Логика возврата книги
    //    cout << "Читатель " << firstName_ << " вернул книгу \"" << book.getTitle() << "\"" << endl;
    //}
};

// Класс Библиотека
class Library {
public:
    void addBook(const Book& book) {
        books_.push_back(book);
        cout << "Книга \"" << book.getTitle() << "\" добавлена в библиотеку." << endl;
    }

    void removeBook(const string& title) {
        for (auto it = books_.begin(); it != books_.end(); ++it) {
            if (it->getTitle() == title) {
                books_.erase(it);
                cout << "Книга \"" << title << "\" удалена из библиотеки." << endl;
                return;
            }
        }
        cout << "Книга \"" << title << "\" не найдена в библиотеке." << endl;
    }

    vector<Book> getBookList() const {
        return books_;
    }

    void printBookList() const {
        cout << "Список книг в библиотеке:" << endl;
        for (const auto& book : books_) {
            cout << "- " << book.getTitle() << " (" << book.getPublicationYear() << ")" << endl;
        }
    }

    bool checkAvailability(const string& title) const {
        for (const auto& book : books_) {
            if (book.getTitle() == title) {
                return true;
            }
        }
        return false;
    }

    void registerReader(Reader reader) {
        readers_.push_back(reader);
        cout << "Читатель " << reader.getName() << " зарегистрирован в библиотеке." << endl;
    }

    void printReadersList() const {
        cout << "Список зарегистрированных читателей:" << endl;
        for (const auto& reader : readers_) {
            cout << "- " << reader.getName() << ", номер регистрации: " << reader.getRegistrationNumber() << endl;
        }
    }

    void selectReaderAndBook() {
        cout << "Введите номер регистрации читателя: ";
        int registrationNumber;
        cin >> registrationNumber;
        for (auto& reader : readers_) {
            if (reader.getRegistrationNumber() == registrationNumber) {
                cout << "Введите название книги: ";
                string title;
                cin.ignore();
                getline(cin, title);
                for (const auto& book : books_) {
                    if (book.getTitle() == title) {
                        reader.selectBook(book);
                        return;
                    }
                }
                cout << "Книга \"" << title << "\" не найдена в библиотеке." << endl;
                return;
            }
        }
        cout << "Читатель с номером регистрации " << registrationNumber << " не найден." << endl;
    }

    void printReadersAndTheirBooks() const {
        cout << "Список зарегистрированных читателей и их выбранных книг:" << endl;
        for (const auto& reader : readers_) {
            cout << "- " << reader.getName() << ":" << endl;
            for (const auto& book : reader.getSelectedBooks()) {
                cout << "  - " << book.getTitle() << endl;
            }
        }
    }

private:
    vector<Book> books_;
    vector<Reader> readers_; // Список зарегистрированных читателей
};

int main() {
    setlocale(LC_ALL, "ru");

    Library library;

    // Создание и добавление книг
    Book book1("War and peace", 1869, 1225, "Leo Tolstoy", "Novel");
    library.addBook(book1);

    Book book2("Сrime and punishment", 1866, 671, "Fyodor Dostoevsky", "Novel");
    library.addBook(book2);

    // Создание и регистрация читателей
    Reader reader1("Ivan", "Ivanov", 1, "ivanov@example.com", "password1");
    library.registerReader(reader1);

    Reader reader2("Peter", "Petrov", 2, "petrov@example.com", "password2");
    library.registerReader(reader2);

    Reader reader("Name", "Surname", 1, "adress", "passvord"); // Создаем нового читателя

    while (true) {
        cout << "Введите:\n\t 1, чтобы добавить книгу,\n\t 2, чтобы удалить книгу,\n\t 3, чтобы вывести список книг,\n\t 4, чтобы зарегистрировать читателя,\n\t 5, чтобы вывести список читателей,\n\t 6, чтобы выбрать читателя и книгу,\n\t 7, чтобы вывести список читателей и их выбранных книг,\nили 0, чтобы выйти: ";
        int choice;
        cin >> choice;

        if (choice == 0) {
            break;
        }
        else if (choice == 1) {
            string title, author, category;
            int publicationYear, totalPages;
            cout << "Введите название книги: ";
            cin.ignore();
            getline(cin, title);
            cout << "Введите год публикации: ";
            cin >> publicationYear;
            cout << "Введите общее количество страниц: ";
            cin >> totalPages;
            cin.ignore();
            cout << "Введите автора: ";
            getline(cin, author);
            cout << "Введите категорию: ";
            getline(cin, category);
            Book book(title, publicationYear, totalPages, author, category);
            library.addBook(book);
        }
        else if (choice == 2) {
            cout << "Введите название книги, которую хотите удалить: ";
            string title;
            cin.ignore();
            getline(cin, title);
            library.removeBook(title);
        }
        else if (choice == 3) {
            library.printBookList();
        }
        else if (choice == 4) {
            string firstName, lastName, email, password;
            int registrationNumber;
            cout << "Введите имя: ";
            cin.ignore();
            getline(cin, firstName);
            cout << "Введите фамилию: ";
            getline(cin, lastName);
            cout << "Введите номер регистрации: ";
            cin >> registrationNumber;
            cin.ignore();
            cout << "Введите email: ";
            getline(cin, email);
            cout << "Введите пароль: ";
            getline(cin, password);
            Reader newReader(firstName, lastName, registrationNumber, email, password);
            library.registerReader(newReader);
        }
        else if (choice == 5) {
            library.printReadersList();
        }
        else if (choice == 6) {
            library.selectReaderAndBook();
        }
        else if (choice == 7) {
            library.printReadersAndTheirBooks();
        }
        else {
            cout << "Неверный ввод. Попробуйте еще раз." << endl;
        }
    }

    return 0;
}
