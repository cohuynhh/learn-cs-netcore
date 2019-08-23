using System;

namespace CS11_Class
{  
    class Student {
            public readonly string name;
            public Student(string name)
            {
                this.name = name;
            }

        }
            // Student s = new Student("Abc");     // khởi tạo biến readonly trong hàm tạo
            // string n = s.name;                  // đọc biển readonly
            // s.name = "AA";                      // lỗi - vì không thể gán - chỉ có thể đọc

}
