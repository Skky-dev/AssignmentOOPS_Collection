using HRLib;
namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region GIT Test
            Console.WriteLine("Git Test");
            #endregion



            try
            {
                ConfirmEmployee confirmEmployee = new ConfirmEmployee(25000, "IT", "Rohit", "Pune");
                Console.WriteLine(confirmEmployee);
                Console.WriteLine("Net Salary: " + confirmEmployee.CalculateSalary());

                Trainee trainee = new Trainee("Sky", "test", 500, 90);
                Console.WriteLine(trainee);

            }
            catch (InvalidBasicSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidDesignationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
