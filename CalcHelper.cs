namespace HW_14CalcHelper
{
    public class CalcHelper
    {
        public static S MINUS<S>(S val_1, S val_2)
        {
            S minus = (dynamic) val_1 - (dynamic) val_2;
            return minus;
        }

        public static S PLUS<S>(S val_1, S val_2)
        {
            S plus = (dynamic) val_1 + (dynamic) val_2;
            return plus;
        }

        public static S DIVIS<S>(S val_1, S val_2)
        {
            S divis = (dynamic) val_1 / (dynamic) val_2;
            return divis;
        }

        public static S MILT<S>(S val_1, S val_2)
        {
            S milt = (dynamic) val_1 * (dynamic) val_2;
            return milt;
        }
        
    }
}