namespace Calculator_UWP.View.Controls
{
	public class AriphmeticNums
	{
		enum EAriphmeticNums { Division, Multiplication, Addition, Subtraction, Equally }

		public char Division { get; } = '/';
		public char Multiplication { get; } = '╳';
		public char Addition { get; } = '+';
		public char Subtraction { get; } = '-';
		public char Equally { get; } = '=';
	}
}
