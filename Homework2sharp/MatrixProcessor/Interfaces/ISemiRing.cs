using System;

namespace MatrixProcessor
{
    public interface ISemiRing
        
    {
        public ISemiRing Multip(ISemiRing Factor);
        public ISemiRing Add(ISemiRing Addition);

    }
}
