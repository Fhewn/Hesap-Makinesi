using System;
using System.Collection.Generic;
using System.Ling;
using System.Text;
using System.Threading.Taks;

namespace Fhewn_Hesap_Makinasi
{
class Program
{
static void Main(string[] args)
{
by secim;
double sayi1, sayi2, sonuc;
Console.WriteLine("1 Toplama");
Console.WriteLine("2 Çıkarma");
Console.WriteLine("3 Çarplama");
Console.WriteLine("4 Bölme");
Console.WriteLine("..............");
Console.WriteLine("İşlem tipinizi seçiniz (1-4)");
secim=Convert.ToByte(Console.ReadLine());
if(secim==1)
{
Console.Clear();
Console.WriteLine("****************");
Console.WriteLine("Seçilen İşlem Toplama İşlemi");
Console.WriteLine("****************");
Console.Write("1.Sayıyı Giriniz");
sayi1=Convert.ToDouble(Console.ReadLine());
Console.Write("2.Sayıyı Giriniz");
sayi2=Convert.ToDouble(Console.ReadLine());
sonuc=sayi1+sayi2;
Console.Write("Sonuç={0}",sonuc);
}
