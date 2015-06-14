namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Table : Element, ITable
    {
        private const string TableName = "table";
        private const string TrOpen = "<tr>";
        private const string TrClose = "</tr>";
        private const string TdOpen = "<td>";
        private const string TdClose = "</td>";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public Table(int rows, int cols)
            : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect input data.The number of rows must be > 0.");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect input data.The number of cols must be > 0.");
                }

                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Incorrect input data.Such an element DOES NOT exist.");
                }

                return this.cells[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException("Incorrect input data.Such an element DOES NOT exist.");
                }
                if (value == null)
                {
                    throw new ArgumentNullException("value","The input data CANNOT be null.");
                }

                this.cells[row, col] = value;
            }
        }

        public override void AddElement(IElement element)
        {
            throw new Exception("Tables do not have child elements.");
        }

        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have child elements!");
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("Cannot get text content of HTML table because it does not have such!");
            }
            set
            {
                throw new InvalidOperationException("Cannot set text content of HTML table because it does not have such!");
            }
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append(TrOpen);

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TdOpen);

                    output.Append(this.cells[row, col].ToString());

                    output.Append(TdClose);
                }

                output.Append(TrClose);
            }

            output.AppendFormat("</{0}>", this.Name);
        }

    }
}
