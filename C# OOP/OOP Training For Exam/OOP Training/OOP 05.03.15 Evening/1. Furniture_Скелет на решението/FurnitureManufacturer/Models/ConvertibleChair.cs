namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const bool InitialState = true;
        private const decimal ChangeHeight = 0.10m;
        private bool isConverted;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = InitialState;
        }

        public bool IsConverted { get; private set; }

        public void Convert()
        {
            if (this.isConverted)
            {
                this.isConverted = false;
            }
            else
            {
                this.isConverted = true;
            }
        }

        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return ChangeHeight;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString());

            output.AppendFormat(", State: {0}", this.IsConverted ? "Converted" : "Normal");

            return output.ToString();
        }
    }
}
