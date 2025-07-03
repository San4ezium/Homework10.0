// See https://aka.ms/new-console-template for more information
var report = new System.Text.StringBuilder();

Console.Write("Title: ");
string title = Console.ReadLine();

report.AppendLine("Report: " + title);
report.AppendLine("Date: " + DateTime.Now.ToShortDateString());
report.AppendLine("Events:");

string line;
while (true)
{
    Console.Write("Enter the event (empty line - complete)): ");
    line = Console.ReadLine();

    if (string.IsNullOrEmpty(line))
        break;

    report.AppendLine("- " + line);
}

Console.WriteLine("\n" + report.ToString());