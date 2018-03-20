using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public class Person
    {
        readonly long registrationNo;
        private string name;
        private DateTime dOB;
        private Address address;
        private uint telephoneNo;

        private static long nextNumber;

        public Person() {
            this.registrationNo = ++nextNumber;
        }

        public Person(string name, DateTime dOB) : this()
        {
            Name = name;
            DOB = dOB;
        }

        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public uint TelephoneNumber
        {
            get { return telephoneNo; }
            set { telephoneNo = value; }
        }

        public long RegistrationNo
        {
            get { return registrationNo; }
        }

        public string GetInfo()
        {
            return String.Format("Reg no: {0}, Name: {1}, DOB: {2:yyyy/MM/dd},\n" +
                                    "Address: Street: {3}, City: {4}, Province: {5}, Tel: {6}", 
                                    RegistrationNo, Name, DOB, 
                                    Address.StreetAddress, Address.City, Address.ProvinceOrTerritory, TelephoneNumber);
        }      
    }
}
