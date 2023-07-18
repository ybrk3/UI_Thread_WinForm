

using System.Diagnostics;

var sw=Stopwatch.StartNew();
await YumurtalariKir();
await YumurtalariPisir();
await YumurtalariServiceEt();

sw.Stop();
Task.Delay(1000).Wait();
Console.WriteLine($"You prepared eggs in {sw.ElapsedMilliseconds} MS");


async Task YumurtalariKir()
{
    await Task.Delay(750);
    Console.WriteLine("Yumurtalar kırıldı.");
}

async Task YumurtalariPisir()
{
    await Task.Delay(2000);
    Console.WriteLine("Yumurtalar pişti.");
}

async Task YumurtalariServiceEt()
{
    await Task.Delay(1000);
    Console.WriteLine("Afiyet olsun");
}