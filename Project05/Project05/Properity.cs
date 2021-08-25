using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05
{
    class Properity 
    {
       

        private string contacttype, name, surname, id, addresshome, address, email, additional;
        private int floor, age, rooms,  bathroom, price, dateofbirth, size, furnished, withOwen, internet, elevator, pool, aircondition, bathtube, water, incutivestew, balcony, securitysystem, gym ;
        private double phonenumber;
        
        public Properity(string contacttype, string name, string surname, string id, string addresshome, string address, string email, string additional, int floor, int age, int rooms,int size, int bathroom, int price, double phonenumber, int dateofbirth, int furnished, int withOwen, int internet, int elevator, int pool, int aircondition, int bathtube, int water, int incutivestew, int balcony, int securitysystem, int gym )
        {
            this.furnished = furnished;
            this.withOwen = withOwen;
            this.internet = internet;
            this.elevator = elevator;
            this.pool = pool;
            this.aircondition = aircondition;
           this.bathtube = bathtube;
            this.water = water;
            this.incutivestew = incutivestew;
            this.balcony = balcony;
            this.securitysystem = securitysystem;
            this.gym = gym;
            this.floor = floor;
            this.age = age;
            this.rooms = rooms;
            this.bathroom = bathroom;
            this.price = price;
            this.dateofbirth = dateofbirth;
            this.contacttype = contacttype;
            this.name = name;
            this.surname = surname;
            this.id = id;
            this.size = size;
            this.addresshome = addresshome;
            this.address = address;
            this.phonenumber = phonenumber;
            this.email = email;
            this.additional = additional;



        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Contacttype
        {
            get
            {
                return contacttype;
            }
            set
            {
                contacttype = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;

            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Addresshome
        {
            get
            {
                return addresshome;
            }

            set
            {
                addresshome = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
                
        }

        public string Additional
        {
            get
            {
                return additional;
            }

            set
            {
                additional = value;
            }
        }

        public Double Phonenumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                phonenumber = value;
            }
        }

            
        public int Floor
        {
            get
            {
                return floor;
            }

            set
            {
                floor = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int Rooms
        {
            get
            {
                return rooms;
            }

            set
            {
                rooms = value;
            }
        }

        public int Bathroom
        {
            get
            {
                return bathroom;
            }

            set
            {
                bathroom = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Dateofbirth
        {
            get
            {
                return dateofbirth;
            }

            set
            {
                dateofbirth = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public int Furnished
        {
            get
            {
                return furnished;
            }
            set
            {
                furnished = value;
            }
        }
       

        public int WithOwen
        {
            get
            {
                return withOwen;
            }

            set
            {
                withOwen = value;
            }
        }

        public int Internet
        {
            get
            {
                return internet;
            }

            set
            {
                internet = value;
            }
        }

        public int Elevator
        {
            get
            {
                return elevator;
            }

            set
            {
                elevator = value;
            }
        }

        public int Pool
        {
            get
            {
                return pool;
            }
            
            set
            {
                pool = value;
            }
                
        }

        public int Aircondition
        {
            get
            {
                return aircondition;
            }

            set
            {
                aircondition = value;
            }
        }

        public int Bathtube
        {
            get
            {
                return bathtube;
            }

            set
            {
                bathtube = value;
            }
        }

        public int Water
        {
            get
            {
                return water;
            }

            set
            {
                water = value;
            }
        }

        public int Incutivestew
        {
            get
            {
                return incutivestew;
            }

            set
            {
                incutivestew = value;
            }
        } 

        public int Balcony
        {
            get
            {
                return balcony;
            }

            set
            {
                balcony = value;
            }
        }

        public int Securitysystem
        {
            get
            {
                return securitysystem;
            }

            set
            {
                securitysystem = value;
            }
        }

        public int Gym
        {
            get
            {
                return gym;
            }

            set
            {
                gym = value;
            }
        } 
    }
}
