namespace eBookManager.Engine
{
    public class DeweyDecimal
    {

        public double Number;
        public string Category
        {   
            get
            {
                if (this.Number < 100.0) {
                    return "General Information";
                }
                else if (this.Number < 200.0)
                {
                    return "Philosophy & Psychology";
                }
                else if (this.Number < 300.0)
                {
                    return "Religion";
                }
                else if (this.Number < 400.0)
                {
                    return "Social Sciences";
                }
                else if (this.Number < 500.0)
                {
                    return "Language";
                }
                else if (this.Number < 600.0)
                {
                    return "Science";
                }
                else if (this.Number < 700.0)
                {
                    return "Technology";
                }
                else if (this.Number < 800.0)
                {
                    return "Arts & Recreation";
                }
                else if (this.Number < 900.0)
                {
                    return "Literature";
                }
                else if (this.Number < 1_000.0)
                {
                    return "History & Geography";
                }
                else
                {
                    return "Category Undefined";
                }

            }
           
        }

        public DeweyDecimal(double number)
        {
            this.Number = number;
        }


    }
}