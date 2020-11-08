using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections;

namespace Yemek_Sepeti___Hızlı_Yapistir
{
    class FileConfig
    {

        public static ArrayList ReadFile(string path)
        {
            ArrayList shortcutListitems = new ArrayList();

            // Delete the file if it exists.
            if (File.Exists(path))
            {
                //File.Delete(path);
                using (StreamReader reader = new StreamReader(path))
                {
                    string fileContent;
                    while (!reader.EndOfStream)
                    {
                        fileContent = reader.ReadLine();
                        shortcutListitems.Add(fileContent);

                    }
                    reader.Close();
                }

                return shortcutListitems;
            }
            return null;
           
        }


        
        public static bool WriteFile(string path,ArrayList dataList)
        {
            try
            {
                if (File.Exists(path)) File.Delete(path);
                using (FileStream fs = File.Create(path))
                {

                    foreach (string value in dataList)
                    {
                        AddText(fs, value + "\n");
                    }
                }

                void AddText(FileStream fs, string value)
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(value);
                    fs.Write(info, 0, info.Length);
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
          

        }
    }

    }
