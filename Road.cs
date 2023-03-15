namespace Extension_Method
{
    public sealed class Road
    {
        public string Number { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number} общей протяженностью {Length}";
        }
    }
}