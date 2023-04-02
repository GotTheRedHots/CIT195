var todoList = new TodoList();

todoList += "Mow the lawn";
todoList += "Vacuum the house";
todoList += "Shear the sheep";

var todoListCopy = todoList;

Console.WriteLine($"Do two lists with the same items equal each other? {todoList == todoListCopy}");

Console.WriteLine("The content of the todo list is:");
foreach (var todo in todoList.todos)
{
    Console.WriteLine(todo);
}

Console.WriteLine("Removing the last item from the list");
todoList--;
foreach (var todo in todoList.todos)
{
    Console.WriteLine(todo);
}

var toDontList = new TodoList();

toDontList += "Chew under the table gum";
toDontList += "Steal candy from babies";
toDontList += "Plagarize some homework";

Console.WriteLine($"Are the todo and toDont lists equal? {todoList == toDontList}");

public class TodoList
{
    public List<string> todos = new List<string>();

    public static TodoList operator +(TodoList left, string right)
    {
        left.todos.Add(right);
        return left;
    }
    public static TodoList operator -(TodoList left, string right)
    {
        left.todos.Remove(right);
        return left;
    }
    public static TodoList operator --(TodoList left)
    {
        if (left.todos.Count > 0)
        {
            left.todos.RemoveAt(left.todos.Count - 1);
        }
        return left;
    }
    public static bool operator ==(TodoList left, TodoList right)
    {
        if (left.todos.Count != right.todos.Count) return false;
        for (int i = 0; i < left.todos.Count; i++)
        {
            if (left.todos[i] != right.todos[i]) return false;
        }
        return true;
    }
    public static bool operator !=(TodoList left, TodoList right) => !(left == right);
}
