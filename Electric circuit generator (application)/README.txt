->RU<-
Вы используете приложение, генерирующее электрические цепи.

Для корректной работы программы необходимо установить Microsoft .Net Framework версии 4.7.2 и выше.
Ссылка на .Net Framework версии 4.8 : https://dotnet.microsoft.com/download/dotnet-framework/net48

Применение:
1)Запуск ECG.exe
2)Ввод количества R, L, C элементов (Number of ...)
3)Выбор источника (Name of source)
	-если источник не выбран, то он будет обозначен как 'source'
4)Ввод значений на R, L, C элементах и источнике (Value of ...)
	-значения генерируются на отрезке [a; b]
	-для выбора конкретного значения вводится отрезок [a; a]
	-пустое поле автоматически приравнивается к нулю в момент генерации
5)Выбор текстового файла (.txt) для сохранения результатов цепи (Find a file to save)
6)Начало генерации(Generate electrical circuit)
	-кнопка доступна, когда выбран путь к файлу
	-галочка означает, что генерация завершена; крестик означает, что генерация не завершена / не начата
7)После генерации есть возможноть нажать на кнопку Refresh (крайняя правая кнопка)
	-кнопка доступна, когда генерация завершена
	-позволяет снова ввести данные (не обязательно)
	-позволяет заново выбрать файл (не обязательно, при этот файл остается тем же)
	-позволяет сгенерировать новую цепь (новая цепь генерируется под предыдущими цепями)

-> ENG <-
You are using an application that generates electrical circuits.

For the program to work correctly, you must install Microsoft .Net Framework version 4.7.2 and higher.
Link to .Net Framework version 4.8: https://dotnet.microsoft.com/download/dotnet-framework/net48

Application:
1)Launch ECG.exe
2)Enter the number of R, L, C elements (Number of ...)
3)Selection the name of source (Name of source)
	-if the source is not selected, it will be marked as 'source'
4)Entering values ​​on R, L, C elements and the source (Value of ...)
	-values ​​are generated on the segment [a; b]
	-sign value generated on the segment [a; a]
	-an empty field is automatically equal to zero at the time of generation
5)Select a text file (.txt) to save the chain results (Find a file to save)
6)Start of generation (Generate electrical circuit)
	-button is available when the file path is selected
	-✔ indicates generation is not completed; ✘ indicates generation is not completed / not started
7) After generation, it is possible to click on the Refresh button (rightmost button)
	-button is available when generation is complete
	-allows you to enter data again (optional)
	-allows you to re-select the file (optional, this file remains the same)
	-allows you to generate a new chain (a new circuit is generated under the previous circuits)
