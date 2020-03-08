namespace Flyweight
{
    public class Code
    {
        public string PieceOfCode {get; set; }
        public Code(string code)
        {
            PieceOfCode = code;
        }

        public override string ToString()
        {
            return $"{ PieceOfCode}";
        }
    }
}