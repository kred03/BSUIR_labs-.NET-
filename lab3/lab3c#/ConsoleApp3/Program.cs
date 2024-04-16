DateService dateService = new DateService();

string dayOfWeek = dateService.GetDay("05.04.2024");
Console.WriteLine("День недели: " + dayOfWeek);

int daysSpan = dateService.GetDaysSpan(10, 4, 2024);
Console.WriteLine("Количество дней между текущей датой и 10.04.2024: " + daysSpan);