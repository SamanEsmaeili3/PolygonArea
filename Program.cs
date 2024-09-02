// See https://aka.ms/new-console-template for more information
var polygon = new List<(double x, double y)>
        {
            (1, 1), (3, 1), (3, 3), (1, 3) // Vertices of a square
        };
var area = PolygonArea.PolygonArea.Instance.CalculatePolygonArea(polygon);
Console.WriteLine("Area is: " + area);