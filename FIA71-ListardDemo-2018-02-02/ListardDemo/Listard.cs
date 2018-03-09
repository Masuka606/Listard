/*
 * fia71@gso-koeln.de 2018
 */
using System;

namespace ListardDemo
{
    //public struct Listard
    public class Listard
    {
        public int[] Values = new int[0];
        public int Length = 0;
        private int count = 0;

        // Konstruktor
        public Listard(int initialCount = 0) {
            Values = new int[initialCount];
        }

        public int Count
        {
            get
            {
                return GetCount();
            }
        }

        public int GetCount()
        {
            return count;
        }

        // Zufügen von Elementen
        public void InsertAt(int value, int index) {
         //   throw new NotImplementedException("wir haben Arbeit hier");
            int[] newValues = new int[Values.Length + 1];

            for(int i = 0 ; i<index;i++)
            {
                newValues[i] = Values[i];
            }
            newValues[index] = value;
            
            for(int i = index + 1; i < Values.Length;i++)
            {
                newValues[i] = Values[i];
            }

            Values = newValues; // Addresse auf neues Objekt richten
        }

        public bool InsertAt(int[] values, int index) {
            throw new NotImplementedException("wir haben Arbeit hier");
        }

        public bool Add(int value) {
            // Neues Array anlegen
            int[] newValues = new int[Values.Length + 1];

            // Alle Elemente kopieren
            // !!! newValues = Values;
            for (int i = 0; i < Values.Length; i++) {
                newValues[i] = Values[i];
            }

            // Neue Element einfügen
            newValues[newValues.Length - 1] = value;

            // Variable "Values" umleiten
            Values = newValues; // Addresse auf neues Objekt richten
            return true;
        }

        public void AddVerySlow(int[] values) {
            // Andere Add-Methode für alle Werte aufrufen
            foreach (int value in values) Add(value);
        }

        //Neuen Eintrag in Arrayanfang
        public void AddFirst(int value)
        {
            int[] newValues = new int[Values.Length + 1];

            newValues[0] = value;

            for (int i = 0; i < Values.Length; i++)
            {
                newValues[i+1] = Values[i];
            }
            // Variable "Values" umleiten
            Values = newValues; // Addresse auf neues Objekt richten,
        }     


        public void Add(int[] values) {
            // Neues Array anlegen
            int[] newValues = new int[Values.Length + values.Length];

            // Alle Elemente kopieren
            // !!! newValues = Values;
            for (int i = 0; i < Values.Length; i++) {
                newValues[i] = Values[i];
            }

            // Neue Element einfügen
            //for (int i = Values.Length, j = 0; i < newValues.Length; i++, j++) {
            //    newValues[i] = values[j];
            //}
            for (int i = 0; i < values.Length; i++) {
                newValues[i + Values.Length] = values[i];
            }

            // Variable "Values" umleiten
            Values = newValues; // Addresse auf neues Objekt richten
        }

        //  Löschen von Elementen
        public bool Delete(int index, int count = 1) {
            throw new NotImplementedException("wir haben Arbeit hier");
        }

        // Zugreifen über Index
        public int Get(int index) {
            return Values[index];
        }

        // C# Properties and Operator Overloading
        public int this[int index] {
            get { return Values[index]; } // lesender Zugriff
            set { Set(value, index); }    // schreibender Zugriff
        }

        public bool Set(int value, int index) {
            // Prüfen, ob der Indes sinnvoll ist
            if (index >= Values.Length) return false;

            // Wert in die interne Liste eintragen
            Values[index] = value;

            return true;
        }
    }
}


// if (myListard.Add(17) == true) { .. }
