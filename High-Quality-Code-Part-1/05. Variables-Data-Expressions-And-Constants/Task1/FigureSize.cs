namespace FigureSize
{
    using System;

    public class FigureSize
    {
        private double width;
        private double height;

        public FigureSize(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public static FigureSize GetRotatedFigure(FigureSize size, double angleOfTheFigureToBeRotated)
        {
            double sinusTimesWidth = Math.Abs(Math.Sin(angleOfTheFigureToBeRotated) * size.Width);
            double cosinusTimesWidth = Math.Abs(Math.Cos(angleOfTheFigureToBeRotated) * size.Width);
            double sinusTimesHeight = Math.Abs(Math.Sin(angleOfTheFigureToBeRotated) * size.Height);
            double cosinusTimesHeigth = Math.Abs(Math.Cos(angleOfTheFigureToBeRotated) * size.Height);

            double rotatedFigureWidth = cosinusTimesWidth + sinusTimesHeight;
            double rotatedFigureHeight = sinusTimesWidth + cosinusTimesHeigth;

            FigureSize rotatedFigure = new FigureSize(rotatedFigureWidth, rotatedFigureHeight);

            return rotatedFigure;
        }
    }
}
