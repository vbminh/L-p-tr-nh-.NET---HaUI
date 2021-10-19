using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_proj61
{
    class Student:Person
    {
        private byte _maths;
        private byte _physics;

        public byte maths
        {
            get { return _maths; }
            set
            {
                if (value >= 0 && value <= 10)
                    _maths = value;
            }
        }
        public byte physics
        {
            get { return _physics; }
            set
            {
                if (value >= 0 && value <= 10)
                    _physics = value;
            }
        }

        public Student()
        {

        }

        public Student(int id, string name, byte math, byte physics) : base(id, name)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public override void input()
        {
            base.input();

            Console.Write("\nNhap diem toan:    ");
            maths = byte.Parse(Console.ReadLine());

            Console.Write("\nNhap diem ly:   ");
            physics = byte.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine($"{maths,10} {physics,10} {tongdiem(),10}");
        }

        public int tongdiem()
        {
            return maths + physics;
        }
    }
}
