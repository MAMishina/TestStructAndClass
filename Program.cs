Console.WriteLine("Подключаем дополнительное пространство имен, создаем экземпляр класса из подключенного пространства, " +
    "выводим данные экземпляра.\n");
Person person = new Person("Lena");
Console.WriteLine(person.name);
Console.ReadLine();

PersonClass class1 = new PersonClass("Kate", 30);
PersonStruct struct1 = new PersonStruct("Roma", 25);


Console.WriteLine("\n\n");
class1.Method("Вася");
class1.Method(class1.name);
Console.WriteLine(class1.name);
Console.WriteLine("\n\n");




Console.WriteLine($"Исходные данные экземпляра класса {class1.name}, {class1.age}");
Console.WriteLine($"Исходные данные экземпляра структуры {struct1.name}, {struct1.age}");
Console.ReadLine();

PersonClass class2 = class1;
PersonStruct struct2 = struct1;

class2.name = "Lina";
class1.age = 105;
struct2.age = 85;

Console.WriteLine("Созданы копии экземпляров класса и структуры. Имя копии экземпляра класса и возраст копии экземпляра " +
    "структуры изменены\n");

Console.WriteLine($"Текущие данные исходного экземпляра класса {class1.name}, {class1.age}");
Console.WriteLine($"Текущие данные копии экземпляра класса {class2.name}, {class2.age}");
Console.ReadLine();

Console.WriteLine($"Текущие данные исходного экземпляра структуры {struct1.name}, {struct1.age}");
Console.WriteLine($"Текущие данные копии экземпляра структуры {struct2.name}, {struct2.age}");
Console.ReadLine();

PersonStruct struct3 = struct2 with { age = 46 };
Console.WriteLine("\nСоздан третий экземпляр структуры - копия второго экземпляра с заменой возраста при создании.\n");
Console.WriteLine($"Возраст трех структур: {struct1.age}, {struct2.age}, {struct3.age}");
Console.ReadLine();

PersonClass class3 = new PersonClass("Kate", 30);
PersonStruct struct4 = new PersonStruct("Roma", 25);
Console.WriteLine($"\nАдреса экземпляров структур: {struct1.GetHashCode()}, {struct2.GetHashCode()}, {struct3.GetHashCode()}, {struct4.GetHashCode()}");
Console.WriteLine($"\nАдреса экземпляров классов: {class1.GetHashCode()}, {class2.GetHashCode()}, {class3.GetHashCode()} ");
Console.ReadLine();