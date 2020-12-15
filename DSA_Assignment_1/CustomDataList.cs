using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Assignment_1
{
    class CustomDataList
    {
        public List<Student> customList;
        public int length;
        public Student first;
        public Student last;
        public CustomDataList(List<Student> customList)
        {
            this.customList = customList;
            length = customList.Count;
        }
        public void Add(Student student)
        {
            customList.Add(student);
            length = length + 1;
            first = customList[0];
            last = student;
        }
        public void GetElement(int index)
        {
            Console.WriteLine(customList[index]);
        }
        public void RemoveByIndex(int index)
        {
            if (index == 0)
            {
                first = customList[1];
            }
            else
            {
                if (index == length - 1)
                {
                    last = customList[length - 2];
                }
            }
            length--;
            customList.RemoveAt(index);
        }
        public void RemoveFirst()
        {
            first = customList[1];
            customList.RemoveAt(0);
            length--;
        }
        public void RemoveLast()
        {
            last = customList[length - 2];
            customList.RemoveAt(length - 1);
            length--;
        }
        public void DisplayList()
        {
            for (int i = 0; i < length; i++)
            {
                GetElement(i);
            }
        }
    }
}
