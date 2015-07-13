namespace RefactorIfStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IfStatement
    {
        static void Main(string[] args)
        {
            const double MIN_X_COORDINATE = -50;
            const double MAX_X_COORDINATE = 50;
            const double MIN_Y_COORDINATE = -50;
            const double MAX_Y_COORDINATE = 50;

            // Testing Task-1
            Potato potato = new Potato();

            bool isReadyForCooking = potato.IsPeeled && !potato.IsRotten;
            if (potato != null && isReadyForCooking)
            {
                Potato.Cook(potato);
            }

            // Task-2
            Cell cell = new Cell(3, 5);

            bool isXInRange = MIN_X_COORDINATE <= cell.X && cell.X <= MAX_X_COORDINATE;
            bool isYInRange = MIN_Y_COORDINATE <= cell.Y && cell.Y <= MAX_Y_COORDINATE;
            if (isXInRange && isYInRange && Cell.ShouldVisitCell())
            {
                cell.VisitCell();
            }
        }
    }
}
