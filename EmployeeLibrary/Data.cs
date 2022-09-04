//PROG 1224 - Lab 3
//Natalie Hyojung Yu
//Date: July 15, 2022

using System;

namespace EmployeeLibrary
{
    public static class Data
    {
        public static Employee[] GetEmployees()
        {
            Employee[] empList = new Employee[20];

            empList[0] = new Hourly("111222333", "Oliver", "Jones", 22m, 36.5m) { 
                HireDate = DateTime.Today.AddYears(-1),
                BirthDate = DateTime.Today.AddYears(-25),
                Email = "ojones@gmail.com",
                Phone = "2891110000",
                Address = new Address("101 Main Street", "Niagara Falls", "ON", "A1B 1C3")
            };

            empList[1] = new Hourly("444555666", "Sophia", "Williams", 20m, 45m) {
                HireDate = DateTime.Today.AddYears(-2),
                BirthDate = DateTime.Today.AddYears(-35),
                Email = "swilliams33@gmail.com",
                Phone = "2892223333",
                Address = new Address("5022 Hill Street", "Niagara Falls", "ON", "L2G 5Y6")
            };

            empList[2] = new Hourly("777888999", "Robert", "Lee", 20m, 35m) {
                HireDate = DateTime.Today,
                BirthDate = DateTime.Today.AddYears(-18),
                Email = "robertlee@hotmail.com",
                Phone = "4162223333",
                Address = new Address("311 Willow Route", "Wellend", "ON", "L4H 5N5")
            };

            empList[3] = new Hourly("123123123", "Megan", "Taylor", 15m, 40m) {
                HireDate = DateTime.Today.AddYears(-1),
                BirthDate = DateTime.Today.AddYears(-22),
                Email = "mtaylor@hotmail.com",
                Phone = "4160009999",
                Address = new Address("3125 Flit Boulevard", "Fort Erie", "ON", "A1B 1B7")
            };

            empList[4] = new Hourly("456456456", "Jacob", "Smith", 25m, 30m) {
                HireDate = DateTime.Today.AddYears(-1),
                BirthDate = DateTime.Today.AddYears(-32),
                Email = "jsmith@gmail.com",
                Phone = "2894445555",
                Address = new Address("80 Spring Way", "St.Catharines", "ON", "K4S 6T9")
            };


            empList[5] = new Salary("333222111", "Lily", "Baker", 68000) {
                HireDate = DateTime.Today.AddYears(-1),
                BirthDate = DateTime.Today.AddYears(-26),
                Email = "lbaker@hotmail.com",
                Phone = "5194445555",
                Address = new Address("5022 Champion Lane", "Port Colborne", "ON", "A1B 1C3")
            };

            empList[6] = new Salary("666555444", "Margaret", "Wilson", 30000) {
                HireDate = DateTime.Today.AddYears(-2),
                BirthDate = DateTime.Today.AddYears(-30),
                Email = "mwilson@gmail.com",
                Phone = "5192223333",
                Address = new Address("5020 Ocean Lane", "St.Catharines", "ON", "L1B 2H2")
            };

            empList[7] = new Salary("999888777", "Daniel", "Anderson", 45000) {
                HireDate = DateTime.Today.AddYears(-3),
                BirthDate = DateTime.Today.AddYears(-33),
                Email = "danderson@hotmail.ca",
                Phone = "5191110000",
                Address = new Address("123 Campus Avenue", "Thorold", "ON", "H3H 4B1")
            };

            empList[8] = new Salary("789789789", "Harry", "White", 60000) {
                HireDate = DateTime.Today.AddYears(-5),
                BirthDate = DateTime.Today.AddYears(-28),
                Email = "hwhite@gmail.com",
                Phone = "2899990000",
                Address = new Address("4211 Bush street", "Niagara Falls", "ON", "T8T 1H1")
            };

            empList[9] = new Salary("123456789", "Samantha", "Martin", 75000) {
                HireDate = DateTime.Today.AddYears(-7),
                BirthDate = DateTime.Today.AddYears(-40),
                Email = "smartin@hotmail.com",
                Phone = "2899991111",
                Address = new Address("125 Cliff Lane", "Niagara on the lake", "ON", "A1B 3E3")
            };


            empList[10] = new Manager("222333444", "Liam", "Johnson", 100000) { 
                HireDate = DateTime.Today.AddYears(-18),
                BirthDate = DateTime.Today.AddYears(-40),
                Email = "ljohnson@hotmail.com",
                Phone = "5194447777",
                Address = new Address("401 Pine Route", "Wellend", "ON", "L2B 2V4")
            };

            empList[11] = new Manager("555666777", "Emma", "Brown", 75000) { 
                HireDate = DateTime.Today.AddYears(-12),
                BirthDate = DateTime.Today.AddYears(-35),
                Email = "ebrown@gmail.com",
                Phone = "2895556666",
                Address = new Address("22 Victory Avenue", "Grimsby", "ON", "L4H 5A1")
            };

            empList[12] = new Manager("888999000", "Mark", "Nelson", 150000) { 
                HireDate = DateTime.Today.AddYears(-21),
                BirthDate = DateTime.Today.AddYears(-60),
                Email = "mnelson@gmail.com",
                Phone = "4197779999",
                Address = new Address("502 Mason Lane", "St.Catharines", "ON", "L2N 2H1")
            };

            empList[13] = new Manager("234234234", "James", "Miller", 60000) { 
                HireDate = DateTime.Today.AddYears(-3),
                BirthDate = DateTime.Today.AddYears(-29),
                Email = "jamesmiller@gmail.com",
                Phone = "5194564444",
                Address = new Address("1855 Blossom Street", "Thorold", "ON", "L2N 1B1")
            };

            empList[14] = new Manager("567567567", "Ava", "Thomas", 75000) { 
                HireDate = DateTime.Today.AddYears(-7),
                BirthDate = DateTime.Today.AddYears(-33),
                Email = "avathomas@hotmail.com",
                Phone = "4198889999",
                Address = new Address("4545 Garden Avenue", "Stoney Creek", "ON", "L2N 1C3")
            };


            empList[15] = new Contract("890890890", "Lauren", "O'Connor", 1300) {
                HireDate = DateTime.Today.AddYears(-1),
                BirthDate = DateTime.Today.AddYears(-25),
                Email = "loconnor@hotmail.com",
                Phone = "2898880000",
                Address = new Address("120 Ivory Boulevard", "Niagara Falls", "ON", "L2N 4Y4")
            };

            empList[16] = new Contract("012012012", "Michael", "Smith", 900) {
                HireDate = DateTime.Today.AddYears(-2),
                BirthDate = DateTime.Today.AddYears(-22),
                Email = "msmith@gmail.com",
                Phone = "2895550202",
                Address = new Address("23 Willow Route", "Wellend", "ON", "L2N 7W1")
            };

            empList[17] = new Contract("000111222", "Sandra", "Carter", 2000) {
                HireDate = DateTime.Today.AddYears(-7),
                BirthDate = DateTime.Today.AddYears(-45),
                Email = "sandrac@yahoo.ca",
                Phone = "2899992222",
                Address = new Address("80 Polygon Route", "Toronto", "ON", "L2N 7T3")
            };

            empList[18] = new Contract("790790790", "Charlotte", "Kim", 1000) {
                HireDate = DateTime.Today.AddYears(-1),
                BirthDate = DateTime.Today.AddYears(-18),
                Email = "ckim@yahoo.com",
                Phone = "5002225656",
                Address = new Address("6655 University Way", "Niagara on the lake", "ON", "L2N 7T7")
            };

            empList[19] = new Contract("333666999", "Charlie", "Roy", 2500) {
                HireDate = DateTime.Today.AddYears(-5),
                BirthDate = DateTime.Today.AddYears(-30),
                Email = "charlieroy@yahoo.ca",
                Phone = "8905554444",
                Address = new Address("754 Queen Street", "Hamilton", "ON", "L2N 1S5")
            };

            return empList;
        }
    }
}
