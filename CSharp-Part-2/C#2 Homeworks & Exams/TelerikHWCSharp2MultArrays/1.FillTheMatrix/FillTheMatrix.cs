using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        int rowCounter = 0;
        int colCounter = 1;
        int row = 0;
        int col = 0;
        string direction = "down";
        int matrixLength = n * n;

        int[,] matrix = new int[n, n];

        if (symbol == 'a')
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colCounter + rowCounter;
                    rowCounter += n;
                }
                rowCounter = 0;
                colCounter++;
            }
        }
        else if (symbol == 'b')
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        matrix[j, i] = colCounter;
                    }
                    else
                    {
                        matrix[(n - 1) - j, i] = colCounter;
                    }
                    colCounter++;
                }

            }
        }
        else if (symbol == 'c')
        {
            for (int i = n - 1; i >= 0; i--)
            {
                row = i;
                col = 0;
                while (row < n && col < n)
                {
                    matrix[row, col] = colCounter;
                    row++;
                    col++;
                    colCounter++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                row = 0;
                col = j;
                while (row < n && col < n)
                {
                    matrix[row, col] = colCounter;
                    row++;
                    col++;
                    colCounter++;
                }
            }
        }
        else
        {
            for (int i = 1; i <= matrixLength; i++)
            {
                // pravim proverka dali sme izleznali izvan matricata(saotvetniq red ili kolona) kato varvim v saotvetnata posoka  sledovatelno e vreme za smqna na posokata!!!
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))  // smenqne posokata kogato varvim nadolo i reda e ve4e po golqm ot broq redove na matricata
                {                           // i  s || matrix[row, col] != 0 si proverqvame dali ve4e ima stoinost na tazi poziciq i smenqme posokata, ako ima za da ne se prepokrivat( poneje defaultnata stoinost na elementite ot masivite e 0,
                    //ako ne e 0 zna4i ve4e sme si zadali stoinost i za da ne se sbalskat(prepokriqt) smenqma posokata kakto e ni po zadanie) i da tragne da palni pak nadolo masiva si pravim tazi proverka(magiq)

                    direction = "right";    // smenqme posokata na saotvetnata po zadanie i
                    row--;                  // namalqvame redovete s 1 za da vlezem otnovo v redovete na matricata i 
                    col++;                  // uveli4avame colonite s 1 za da otidem na sledva6tat poziciq v matricataa koqto iskame
                }
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row++;
                    col--;
                }
                if (direction == "left" && (col <= 0 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col++;
                    row++;
                }
                // filling the matrix
                matrix[row, col] = i;
                // proverqvame posokata i mestim nadolo, ladqsno, nagore, nalqvo po poziciite na matricata, za da napalnim zaotvetnata poziciq s pravilnoto 4islo
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "up")
                {
                    row--;
                }
                if (direction == "left")
                {
                    col--;
                }
            }
        }
        // printing the matrix

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j > n - 2)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                else
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}

