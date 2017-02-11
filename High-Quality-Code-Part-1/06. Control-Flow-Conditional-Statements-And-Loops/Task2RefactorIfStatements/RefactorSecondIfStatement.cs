namespace Task2RefactorIfStatements
{
    using System;

    public class RefactorSecondIfStatement
    {
        public void RefactorIfStatement()
        {
            const int RECTANGLE_MIN_WIDTH = 1;
            const int RECTANGLE_MAX_WIDTH = 10;
            const int RECTANGLE_MIN_HEIGHT = 1;
            const int RECTANGLE_MAX_HEIGHT = 10;

            bool shouldVisitCell = true;
            var currentRectangleWidth = 3;
            var currentRectangleHeight = 3;

            if (currentRectangleWidth >= RECTANGLE_MIN_WIDTH && currentRectangleWidth <= RECTANGLE_MAX_WIDTH)
            {
                if (RECTANGLE_MAX_HEIGHT >= currentRectangleHeight && RECTANGLE_MIN_HEIGHT <= currentRectangleHeight)
                {
                    if (shouldVisitCell)
                    {
                        this.VisitCell();
                    }
                }
            }
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
