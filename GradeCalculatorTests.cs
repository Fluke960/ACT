using NUnit.Framework;

namespace StudentGrades.nUnitTests

{
	public class GradeCalculatorTests
	{
		private GradeCalculator GradeCalculator { get; set; }

		[SetUp]
		public void Setup()
		{
			GradeCalculator = new GradeCalculator();
		}

		[TestCase(49)]
		[TestCase(86)]
		[TestCase(73)]
		[TestCase(53)]
		[TestCase(83)]
		[TestCase(80)]
		[TestCase(55)]
		[TestCase(38)]
		[TestCase(94)]
		[TestCase(98)]
		[TestCase(36)]
		[TestCase(21)]
		[TestCase(24)]
		[TestCase(95)]
		[TestCase(12)]
		[TestCase(28)]
		[TestCase(14)]
		[TestCase(42)]
		[TestCase(33)]
		[TestCase(48)]
		public void GetGradePercentage_EqualTest(int percentage)
		{
			// Assign
			//ing percentage = 99;

			// Act
			string grade = GradeCalculator.GetGradePercentage(percentage);
			// Assert
			if (percentage >= 90)
				Assert.That(grade, Is.EqualTo("A"));
			else if (percentage >= 80)
				Assert.That(grade, Is.EqualTo("B"));
			else if (percentage >= 70)
				Assert.That(grade, Is.EqualTo("C"));
			else if (percentage >= 60)
				Assert.That(grade, Is.EqualTo("D"));
			else
				Assert.That(grade, Is.EqualTo("F"));
		}


	}
}
