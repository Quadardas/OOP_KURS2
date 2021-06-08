using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
        [Serializable]
        public class Block 
        {
            public List<Doctor> doctors = new List<Doctor>();
            public List<Patient> patients = new List<Patient>();
            public List<Services> services = new List<Services>();

    

        }
        public class Serialize
        {

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            Block CaptureBlock(Block Temp)
            {
                Temp.doctors = DB.doctors;
                Temp.patients = DB.patients;
                Temp.services = DB.services;

                return Temp;
            }

            public void Save()
            {
                using (FileStream fileStream = new FileStream("File.baka", FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, CaptureBlock(new Block()));
                }
            }

            Block GetDeserializedBlock()
            {
                Block DeserializeBlock;
                using (FileStream fileStream = new FileStream("File.baka", FileMode.OpenOrCreate))
                {
                    DeserializeBlock = binaryFormatter.Deserialize(fileStream) as Block;
                }
                return DeserializeBlock;
            }

            void SetDB(Block loadBlock)
            {
                DB.doctors = loadBlock.doctors;
                DB.patients = loadBlock.patients;
                DB.services = loadBlock.services;
            }

            public void Load()
            {
                SetDB(GetDeserializedBlock());
            }
        }
}

