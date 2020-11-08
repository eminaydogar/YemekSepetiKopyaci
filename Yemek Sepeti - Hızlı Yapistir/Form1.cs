using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yemek_Sepeti___Hızlı_Yapistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ListenKeys();

        }

        private int itemcounter = 1;
        ArrayList shortcutItemsArrayList = new ArrayList();
        private string maintxtpath = AppDomain.CurrentDomain.BaseDirectory + "\\txtfiles\\main.txt";


        globalKeyboardHook klavyeDinleyicisi = new globalKeyboardHook();
        public void ListenKeys()
        {
            // hangi tuşları dinlemek istiyorsak burada ekliyoruz
            // Ben burada sadece M harfine basılınca tetiklenecek şekilde ayarladım
            klavyeDinleyicisi.HookedKeys.Add(Keys.Control);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D1);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D2);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D3);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D4);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D5);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D6);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D7);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D8);
            klavyeDinleyicisi.HookedKeys.Add(Keys.D9);


            //basıldığında ilk burası çalışır
            klavyeDinleyicisi.KeyDown += new KeyEventHandler(islem1);
            //basıldıktan sonra ikinci olarak burası çalışır
            klavyeDinleyicisi.KeyUp += new KeyEventHandler(islem2);
        }
        void islem1(object sender, KeyEventArgs e)
        {
            //Yapılmasını istediğiniz kodlar burada yer alacak
            //Burası tuşa basıldığı an çalışır

            try
            {
                if (e.KeyCode == Keys.D1)
                {
                    Clipboard.SetText(lbShortcutList.Items[0].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D2)
                {
                    Clipboard.SetText(lbShortcutList.Items[1].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D3)
                {
                    Clipboard.SetText(lbShortcutList.Items[2].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D4)
                {
                    Clipboard.SetText(lbShortcutList.Items[3].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D5)
                {
                    Clipboard.SetText(lbShortcutList.Items[4].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());

                }
                else if (e.KeyCode == Keys.D6)
                {
                    Clipboard.SetText(lbShortcutList.Items[5].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D7)
                {
                    Clipboard.SetText(lbShortcutList.Items[6].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D8)
                {
                    Clipboard.SetText(lbShortcutList.Items[7].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
                else if (e.KeyCode == Keys.D9)
                {
                    Clipboard.SetText(lbShortcutList.Items[8].ToString());
                    // MessageBox.Show(e.KeyCode.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen listedeki kopyalamak istediğiniz alanın boş olup olmadığını kontrol ediniz",
                    "UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           


            //Eğer buraya gelecek olan tuşa basıldığında
            //o tuşun normal işlevi yine çalışsın istiyorsanız
            //e.Handled değeri false olmalı
            //eğer ilgili tuşa basıldığında burada yakalansın
            // ve devamında tuş başka bir işlev gerçekleştirmesin
            //istiyorsanız bu değeri true yapmalısınız
            e.Handled = false;
        }

        void islem2(object sender, KeyEventArgs e)
        {
            //Yapılmasını istediğiniz kodlar burada yer alacak
            // Burası ilgili tuşlara basılıp çekildikten sonra çalışır



            //Eğer buraya gelecek olan tuşa basıldığında
            //o tuşun normal işlevi yine çalışsın istiyorsanız
            //e.Handled değeri false olmalı
            //eğer ilgili tuşa basıldığında burada yakalansın
            // ve devamında tuş başka bir işlev gerçekleştirmesin
            //istiyorsanız bu değeri true yapmalısınız
            e.Handled = true;
        }


        void loadTxtFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.ExecutablePath;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        lbShortcutList.Items.Clear();
                        lbShortcutListIndex.Items.Clear();
                        itemcounter = 1;

                        filePath = openFileDialog.FileName;

                        Stream fileStream = openFileDialog.OpenFile();
                        string fileExt = Path.GetExtension(openFileDialog.FileName);
                        if (fileExt != ".txt")
                        {
                            MessageBox.Show("Lütfen bir txt dosyası seçimi yapınız !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                while (!reader.EndOfStream)
                                {
                                    fileContent = reader.ReadLine();
                                    lbShortcutList.Items.Add(fileContent);
                                    addItemCounter();
                                }
                                reader.Close();
                            }
                        }
                        
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Uygulamada hata alındı!", "HATA", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Get the path of specified file

                }
            }
        }

        void addItemCounter()
        {
            lbShortcutListIndex.Items.Add("Seçim " + itemcounter);
            itemcounter++;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.BackColor = Color.FromArgb(24, 25, 38);
            if (FileConfig.ReadFile(maintxtpath) != null)
            {
                shortcutItemsArrayList = FileConfig.ReadFile(maintxtpath);
                foreach (string value in shortcutItemsArrayList)
                {
                    lbShortcutList.Items.Add(value);
                    addItemCounter();
                } 
            }
            
        }

        private void btnaddList_Click(object sender, EventArgs e)
        {
            if (itemcounter < 14)
            {
                if (string.IsNullOrEmpty(tbShortcutElement.Text) || 
                   string.IsNullOrWhiteSpace(tbShortcutElement.Text))
                {
                    return;
                }

                    lbShortcutList.Items.Add(tbShortcutElement.Text);
                    addItemCounter();
                    tbShortcutElement.Clear();
                

            }
            else MessageBox.Show("Listeye Daha Fazla Eleman Eklenemez!", "UYARI",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void startListenKey_Click(object sender, EventArgs e)
        {
            if (lbShortcutList.Items.Count > 0)
            {
                ListenKeys();
                lbStateValue.Text = "Aktif";
                lbStateValue.ForeColor = Color.Green;
            }
                
            else MessageBox.Show("Listede herhangi bir eleman olmadan program başlatılamaz.Lütfen listeye ekleme yapınız!",
                "UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void removeSelectedItem_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedIndex = lbShortcutList.SelectedIndex;
                lbShortcutList.Items.RemoveAt(selectedIndex);
                lbShortcutListIndex.Items.RemoveAt(selectedIndex);
                itemcounter--;
                lbShortcutList.Refresh();
                lbShortcutListIndex.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silinecek elemanı seçiniz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void chooseFromFile_Click(object sender, EventArgs e)
        {

            loadTxtFile();
        }

        private void deleteAllElementFromShortcutList_Click(object sender, EventArgs e)
        {
            if (lbShortcutList.Items.Count == 0) return;

            lbShortcutList.Items.Clear();
            lbShortcutListIndex.Items.Clear();
            lbShortcutList.Refresh();
            lbShortcutListIndex.Refresh();
            itemcounter = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            shortcutItemsArrayList.Clear();
            foreach (var items in lbShortcutList.Items) shortcutItemsArrayList.Add(items);
            FileConfig.WriteFile(maintxtpath, shortcutItemsArrayList);
        }

        private void btnStopApp_Click(object sender, EventArgs e)
        {
            
        }
    }

}











   