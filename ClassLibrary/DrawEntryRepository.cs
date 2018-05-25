using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DrawEntryRepository
    {
        List<DrawEntry> drawEntriesList = new List<DrawEntry>();

        static DrawEntryRepository drawEntrySingleton;

        public static DrawEntryRepository Instance
        {
            get
            {
                if(drawEntrySingleton == null)
                {
                    drawEntrySingleton = new DrawEntryRepository();
                }
                return drawEntrySingleton;
            }

        }
        private DrawEntryRepository()
        {
            //drawEntriesList.Add(new DrawEntry("FCPorto@tudooquepuderes.com", "e02604af130546419d22d371a966c102"));
            //drawEntriesList.Add(new DrawEntry("Boavista@tudooquepuderes.com", "2ac489538cae48c396109e65ad7b3972"));
            //drawEntriesList.Add(new DrawEntry("Sporting@nestum.com", "3327c648d0d747c3904619709d13c68c"));
            drawEntriesList = DatabaseAccess.GetEntryList().ToList();

        } 
        private bool SerialNumberExists(string serial)
        {
            bool value = false;
            FileInfo file = new FileInfo("Serials.txt");
            if (file.Exists)
            {
                FileStream fileStream = file.OpenRead();
                StreamReader streamReader = new StreamReader(fileStream);
                while(streamReader.Peek() != -1)
                {
                    if(serial == streamReader.ReadLine())
                    {
                        value = true;
                        break;
                        
                    }
                }
                streamReader.Dispose();
                fileStream.Dispose();
            }
            return value;
        }

        public void Add(DrawSubmition drawSubmition)
        {
            if(drawSubmition.Age >= 18)
            {
                if (SerialNumberExists(drawSubmition.ProductSerialNumber))
                {

                    int entriesCount = 0;
                    foreach (DrawEntry drawentry in drawEntriesList)
                    {
                        if (drawentry.Email == drawSubmition.Email && drawentry.ProductSerialNumber == drawSubmition.ProductSerialNumber)
                        {
                            entriesCount++;
                        }
                    }
                    if (entriesCount < 2)
                    {
                        DrawEntry drawEntry = new DrawEntry(drawSubmition.Email, drawSubmition.ProductSerialNumber);
                        drawEntriesList.Add(drawEntry);
                        DatabaseAccess.Add(drawEntry);
                    }
                }
            }

        }
        public IEnumerable<DrawEntry> GetEntryList()
        {
            return drawEntriesList;
        }


    }
}
