using System.Windows.Forms;

using word = Microsoft.Office.Interop.Word; //Підключаємо функції ворду

namespace LaptopShop
{
    internal class Word
    {
        public word.Application wordapp; // Змінна для звязку з вордом
        public word.Document doc; // Змінна вказує безпосередньо на сторінку куди виводимо текст

        // Оголошення констант вирівнювання тексту
        public word.WdParagraphAlignment ALeft = word.WdParagraphAlignment.wdAlignParagraphLeft;//Лівий край
        public word.WdParagraphAlignment ARight = word.WdParagraphAlignment.wdAlignParagraphRight;//Правий край
        public word.WdParagraphAlignment ACenter = word.WdParagraphAlignment.wdAlignParagraphCenter;//По центру
        public word.WdParagraphAlignment AJustify = word.WdParagraphAlignment.wdAlignParagraphJustify;// По ширині

        public void loadWord(bool visible = true) //Завантажує ворд
        {
            wordapp = new word.Application(); //Завантажуе ворд і ініціалізує звязок
            wordapp.Visible = visible; //Показує ворд на екрані
            doc = wordapp.Documents.Add();//Додає новий документ
        }

        public void setFont(int b = 0, int i = 0, int u = 0, int size = 0, int color = 0, string font = "",
 word.WdParagraphAlignment align = word.WdParagraphAlignment.wdAlignParagraphLeft)
        //Встановлює поточне форматування
        //font - назва шрифту
        {
            wordapp.Selection.Paragraphs.Alignment = align; //задаємо вирівнювання
            wordapp.Selection.Font.Bold = b;//задаємо жирність
            wordapp.Selection.Font.Italic = i;//задаємо курсив

            if (u == 1) { wordapp.Selection.Font.Underline = word.WdUnderline.wdUnderlineSingle; } //якщо 1 задаємо підкреслення
            else { wordapp.Selection.Font.Underline = word.WdUnderline.wdUnderlineNone; } //якщо 0 знімаємо підкреслення
            if (font != "") wordapp.Selection.Font.Name = font; //задаємо назву шрифта
            if (size != 0) wordapp.Selection.Font.Size = size;//задаємо розмір шрифта
        }

        //Вставляємо таблицю в поточну позицію і примінюємо
        //форматування заголовків та тіла таблиці
        public void insertTable(DataGridView dg, int i = 0,
        int Hb = 1, int Hi = 0, int Hu = 0, int Hsize = 0, int Hcolor = 0, string Hfont = "",
        word.WdParagraphAlignment Halign = word.WdParagraphAlignment.wdAlignParagraphCenter,
        int Bb = 0, int Bi = 0, int Bu = 0, int Bsize = 0, int Bcolor = 0, string Bfont = "",
        word.WdParagraphAlignment Balign = word.WdParagraphAlignment.wdAlignParagraphCenter)
        {
            int r = dg.RowCount; int c = dg.ColumnCount; //для зручності виносимо в змінні кількість рядків і стовпців
            setFont(Bb, Bi, Bu, Bsize, Bcolor, Bfont, Balign);

            //Задаємо форматування тіла таблиці, для того щоб вона створилася із цим стилем,
            // а стиль клітинки заголовку будемо задавати кожен раз окремо

            wordapp.ActiveDocument.Tables.Add(wordapp.Selection.Range, 2, c, 1, 0);// вставляємо таблицю з 2-х рядків і «с» колонок

            for (int hc = 0; hc < c; hc++) //перебираємо заголовки сітки через змінну hc
            {
                setFont(Hb, Hi, Hu, Hsize, Hcolor, Hfont, Halign); //задаємо стиль клітинці
                wordapp.Selection.TypeText(dg.Columns[hc].HeaderText + "");//вставляємо текст в клітинку
                wordapp.Selection.MoveRight(12, 1);//переходимо в наступну клітинку
            }

            for (int cr = 0; cr < r; cr++) //перебираємо стовпці сітки через змінну cr
            {
                for (int cc = 0; cc < c; cc++) //перебираємо рядки сітки через змінну сс
                {
                    wordapp.Selection.TypeText(dg.Rows[cr].Cells[cc].Value + "");//вставляємо значення в клітинку
                    //якщо це не останній рядок і не остання клітинка, переходимо до наступної
                    //якщо наступної немає, вона автоматично створиться
                    if ((cr < r - 1) || ((cc != c - 1) && (cr != r))) wordapp.Selection.MoveRight(12, 1);
                }
            }

            // Якщо параметр 'i' дорівнює 1, то виконати наступні дії
            if (i == 1)
            {
                // Отримати посилання на останню таблицю в документі Word
                word.Table table = wordapp.ActiveDocument.Tables[wordapp.ActiveDocument.Tables.Count];

                // Задати внутрішні відступи для нижньої і верхньої границь таблиці
                table.BottomPadding = 8;
                table.TopPadding = 8;

                // Встановити колір зовнішніх та внутрішніх границь таблиці на білий
                table.Borders.OutsideColor = word.WdColor.wdColorWhite;
                table.Borders.InsideColor = word.WdColor.wdColorWhite;
            }

        }
    }
}

