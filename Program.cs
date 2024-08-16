using System.Globalization;
using System.Text.RegularExpressions;
using CommandLine;
using CsvSerializer;

class Program {
    private static string[] longValues = ["ItemsInFolder", "DeletedItemsInFolder", "ItemsInFolderAndSubfolders", "DeletedItemsInFolderAndSubfolders"];
    private static string[] byteValues = ["FolderAndSubfolderSize", "FolderSize"];

    public static void Main(string[] args) {
        if (!File.Exists(args[0])) {
            Console.WriteLine($"File {args[0]} not found.");
            return;
        }

        var mailboxes = new List<Mailbox>();

        using (var stream = new StreamReader(args[0]))
        {
            Mailbox mailbox = new();
            bool set = false;
            while (!stream.EndOfStream) {
                string? line = stream.ReadLine();
                if (string.IsNullOrEmpty(line) || line.Equals(Environment.NewLine)) {
                    if (set)
                        mailboxes.Add(mailbox);
                    mailbox = new();
                    set = false;
                    continue;
                }

                string key = line[..34].Trim();
                string value = line[36..].Trim();

                if (key == "Date") {
                    mailbox.Date = DateTime.Parse(value);
                    set = true;
                    continue;
                }
                if (longValues.Contains(key)){
                    var parsed = long.TryParse(value, out long longValue);
                    if (!parsed)
                        continue;
                    
                    typeof(Mailbox).GetProperty(key)?.SetValue(mailbox, longValue);
                    set = true;
                    continue;
                }
                if (byteValues.Contains(key)) {
                    string? byteString = Regex.Match(value, @"\(([^)]*)\)").Groups[1].Value;
                    if (string.IsNullOrEmpty(byteString)) {
                        continue;
                    }
                    var spaceIndex = byteString.IndexOf(' ');
                    if(spaceIndex < 1) {
                        continue;
                    }

                    string numberString = byteString[..(spaceIndex)];
                    var parsed = long.TryParse(numberString, NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out long number);
                    if (parsed) {
                        typeof(Mailbox).GetProperty(key)?.SetValue(mailbox, number);
                    set = true;
                    }
                    continue;
                }

                typeof(Mailbox).GetProperty(key)?.SetValue(mailbox, value);
                set = true;
            }
        }

        string newFile = Path.ChangeExtension(args[0], "csv");
        var serializer = new Serializer();
        var handle = File.OpenHandle(newFile, FileMode.Create, FileAccess.Write);
        using var fileWriter = new FileStream(handle, FileAccess.Write);
        serializer.Serialize(fileWriter, mailboxes);
    }
}