using System;

namespace MatrixProcessor
{
    public class MyBoolean : ISemiRing, IOrder, ISerializable
    {
        public bool Value { get; private set; }

        public MyBoolean()
        {
            this.Value = false;
        }

        public MyBoolean(bool Value)
        {
            this.Value = Value;
        }

        public ISemiRing Add(ISemiRing Addition)
        {
            return new MyBoolean((Addition as MyBoolean).Value || this.Value);
        }

        public ISemiRing Multip(ISemiRing Factor)
        {
            return new MyBoolean((Factor as MyBoolean).Value && this.Value);
        }

        public void FromWord(string word)
        {
            if (word.Equals("t"))
                this.Value = true;
            else if (word.Equals("f"))
                this.Value = false;
            else
                throw new ArgumentException("Only true or false");
        }

        public string ToWord()
        {
            
            if (this.Value) return "t";
            else
                return "f";
        }

        public bool LesorEqu(IOrder Item)
        {
            return this.Value || !(Item as MyBoolean).Value; // Boolean algebra magic
        }

        public override bool Equals(object obj)
        {
            return Value.Equals((obj as MyBoolean).Value);
        }
    }
}
