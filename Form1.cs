using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавляем домены
            ComboBox_Domain.Items.AddRange(new string[] { "@mail.ru", "@gmail.com", "@yandex.ru", "@outlook.com" });
            ComboBox_Domain.SelectedIndex = ComboBox_Domain.Items.Count > 0 ? 0 : -1; // Устанавливаем первый элемент по умолчанию
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string input = TextBox1_Label.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите Фамилию и Имя через пробел.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] nameParts = input.Split(' ');
            if (nameParts.Length != 2)
            {
                MessageBox.Show("Введите только Фамилию и Имя через один пробел.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lastName = nameParts[0];
            string firstName = nameParts[1];

            string transliteredLastName = Transliterate(lastName);
            string transliteredFirstName = Transliterate(firstName);

            FirstName_Label.Text = transliteredLastName;
            LastName_Label.Text = transliteredFirstName;

            string login = $"{transliteredFirstName[0].ToString().ToLower()}.{transliteredLastName.ToLower()}";
            Login_Label.Text = login;

            if (ComboBox_Domain.SelectedItem == null)
            {
                MessageBox.Show("Выберите домен для email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string domain = ComboBox_Domain.SelectedItem.ToString();
            string email = $"{login}{domain}";
            Email_Label.Text = email;

            string password = GeneratePassword(16);
            Password_Label.Text = password;
        }

        private string Transliterate(string text)
        {
            Dictionary<char, string> translitMap = new Dictionary<char, string>() {
                {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"}, {'е', "e"},
                {'ё', "yo"}, {'ж', "zh"}, {'з', "z"}, {'и', "i"}, {'й', "y"}, {'к', "k"},
                {'л', "l"}, {'м', "m"}, {'н', "n"}, {'о', "o"}, {'п', "p"}, {'р', "r"},
                {'с', "s"}, {'т', "t"}, {'у', "u"}, {'ф', "f"}, {'х', "kh"}, {'ц', "ts"},
                {'ч', "ch"}, {'ш', "sh"}, {'щ', "sch"}, {'ъ', ""}, {'ы', "y"}, {'ь', ""},
                {'э', "e"}, {'ю', "yu"}, {'я', "ya"},
                {'А', "A"}, {'Б', "B"}, {'В', "V"}, {'Г', "G"}, {'Д', "D"}, {'Е', "E"},
                {'Ё', "Yo"}, {'Ж', "Zh"}, {'З', "Z"}, {'И', "I"}, {'Й', "Y"}, {'К', "K"},
                {'Л', "L"}, {'М', "M"}, {'Н', "N"}, {'О', "O"}, {'П', "P"}, {'Р', "R"},
                {'С', "S"}, {'Т', "T"}, {'У', "U"}, {'Ф', "F"}, {'Х', "Kh"}, {'Ц', "Ts"},
                {'Ч', "Ch"}, {'Ш', "Sh"}, {'Щ', "Sch"}, {'Ъ', ""}, {'Ы', "Y"}, {'Ь', ""},
                {'Э', "E"}, {'Ю', "Yu"}, {'Я', "Ya"}
            };

            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (translitMap.ContainsKey(c))
                    result.Append(translitMap[c]);
                else
                    result.Append(c);
            }

            return result.ToString();
        }

        private string GeneratePassword(int length)
        {           
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
        }

        private void FirstName_Label_Click(object sender, EventArgs e) => Clipboard.SetText(FirstName_Label.Text);
        private void LastName_Label_Click(object sender, EventArgs e) => Clipboard.SetText(LastName_Label.Text);
        private void Login_Label_Click(object sender, EventArgs e) => Clipboard.SetText(Login_Label.Text);
        private void Email_Label_Click(object sender, EventArgs e) => Clipboard.SetText(Email_Label.Text);
        private void Password_Label_Click(object sender, EventArgs e) => Clipboard.SetText(Password_Label.Text);

    }
}