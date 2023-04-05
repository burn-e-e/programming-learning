package bd2.Association;

class Main {
     public static void main(String[] args) {
          Teacher teacher1 = new Teacher("John Doe", "Mathematics");
          Teacher teacher2 = new Teacher("Jane Smith", "English");

          Student student1 = new Student("Alice", 1);
          Student student2 = new Student("Bob", 2);

          teacher1.setStudents(student1);
          teacher1.setStudents(student2);
          teacher2.setStudents(student1);

          student1.printTeachers();
          student2.printTeachers();

          teacher1.printStudents();
          teacher2.printStudents();
     }
}