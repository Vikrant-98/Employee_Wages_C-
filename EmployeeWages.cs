using System;

namespace EmployeeWage
{
    class EmployeeWages
    {
        Random random = new Random();
        public int FULL_TIME_EMPLOYEE = 8, DAILY_FULL_TIME = 160 , PER_HOUR = 20;
        public int PART_TIME_EMPLOYEE = 4, DAILY_PART_TIME = 80;
        public int fullTimeTotal = 0, partTimeTotal = 0, fullTimeHours = 0, partTimeHours = 0;
        public int employee, fullTimeMounthly = 0, partTimeMonthly = 0;
        public int fullHour = 0, partHour = 0 , dayCount = 0;
        static void Main(string[] args)
        {
            EmployeeWages obj = new EmployeeWages();
            obj.DailyWages();
        }
        /// <summary>
        /// Daily Wages calculated
        /// Present functon, MonthlyWages and WorkingHour is called
        /// </summary>
        public void DailyWages()                                                         
        {
            while (dayCount != 20)
            {
                employee = Present(PER_HOUR, FULL_TIME_EMPLOYEE);
                Console.WriteLine("Daily Wages of Full Time Employee is :" + employee);
                if (employee != 0)
                {
                    fullTimeMounthly = MounthlyWages(employee);
                    fullHour = WorkingHour(employee);                          
                }
                employee = Present(PER_HOUR, PART_TIME_EMPLOYEE);
                Console.WriteLine("Daily Wages of Part Time Employee is :" + employee);
                if (employee != 0)
                {
                    partTimeMonthly = MounthlyWages(employee);
                    partHour = WorkingHour(employee);                           
                }
                dayCount++;
            }
            Console.WriteLine("Mounthly Wages of Full Time Employee is :" + fullTimeMounthly);  //Total wage Full time
            Console.WriteLine("Mounthly Wages of Part Time Employee is :" + partTimeMonthly);   //Total wage Part time
            Console.WriteLine("Monthly Hours of Full Time Employee is :" + fullHour);           //Monthly Hour Full time
            Console.WriteLine("Monthly Hours of Part Time Employee is :" + partHour);           //Monthly Hour Part time
        }
        /// <summary>
        /// Check weathe Employee is present or not
        /// Local variable perHour and perDay is used
        /// </summary>
        /// <param name="perHour"></param>
        /// <param name="perDay"></param>
        /// <returns></returns>
        public int Present(int perHour, int perDay)                                      
        {
            int isPresent = random.Next();
            isPresent = isPresent % 2;
            if (isPresent == 1)
            {
                Console.WriteLine("Employee is Present");
                return perHour * perDay;                                                 
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                return 0;
            }
        }
        /// <summary>
        /// Calculating the monthly Wages of part time and full time employee
        /// If employee is present the working day ger added
        /// It returns the Monthly wages
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public int MounthlyWages(int employee)                                           
        {
            if (employee == DAILY_FULL_TIME)
            {
                fullTimeTotal = fullTimeTotal + employee;
                return fullTimeTotal;
            }
            else if (employee == DAILY_PART_TIME)
            {
                partTimeTotal = partTimeTotal + employee;
                return partTimeTotal;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Calculate the total hour in which employee works 
        /// If employee is present the working hour ger added
        /// Returns the working days
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public int WorkingHour(int employee)                                              
        {
            if (employee == DAILY_FULL_TIME)
            {
                fullTimeHours = fullTimeHours + FULL_TIME_EMPLOYEE;                                        
                return fullTimeHours;
            }
            else if (employee == DAILY_PART_TIME)
            {
                partTimeHours = partTimeHours + PART_TIME_EMPLOYEE;                                       
                return partTimeHours;
            }
            else
            {
                return 0;
            }
        }
    }
}
