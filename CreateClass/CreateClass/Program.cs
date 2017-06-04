﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Perosn
    {
        private string name;

        public string Name
        {
            get { return name }
            set { name = value }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate}
            set { birthDate = value }
        }

        public Perosn(string name, DateTime birthDate)
        {

            this.name = name;
            this.birthDate = birthDate;
        }
        public enum Genders : int { Male, Female };

        public Genders gender;

        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.name, this.birthDate));
        }
    }

}

