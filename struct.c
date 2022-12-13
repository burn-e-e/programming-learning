#include <stdio.h>
#include <stdbool.h>

struct Anket
{
     char name[15];
     int age;
     char gender[20];
     int class;
     char male = "f";
};
void main()
{
     struct Anket student;
     printf("Name = ");
     scanf("%s", &student.name);

     printf("Age = ");
     scanf("%d", &student.age);

     printf("Gender 'f' , 'm' = ");
     scanf("%s", &student.gender);

     printf("Class = ");
     scanf("%d", &student.class);

     if (student.gender == 'f')
     {
          student.gender = "Female";
     }
     else
     {
          student.gender = "Male";
     }

     printf("% s\t % d \t %s \t %d", student.name, student.age, student.gender, student.class);
     return 0;
}