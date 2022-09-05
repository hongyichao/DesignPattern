// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");


UnsupportedFormatHandler unsupportedFormatHandler = new UnsupportedFormatHandler(null);

QuickBooksReader quickBooksReader = new QuickBooksReader(unsupportedFormatHandler);

NumbersSheetReader numbersSheetReader = new NumbersSheetReader(quickBooksReader);

ExcelSheetReader excelSheetReader = new ExcelSheetReader(numbersSheetReader);

DataReader dataReader = new DataReader(excelSheetReader);

dataReader.Read("test.qsbw");

