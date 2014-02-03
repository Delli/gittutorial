namespace gittester
{
    public class Calculator
    {
        private int _cvalue;

        public Calculator(int cvalue)
        {
            this._cvalue = cvalue;
        }

        public void AddNumber(int val)
        {

            _cvalue = Cvalue + val;
        }

        public int Cvalue
        {
            get { return _cvalue; }
            set { _cvalue = value; }
        }
    }
}