# BlazorLearn

- Blazor WebAssembly, JavaScript öğrenmek veya kullanmak zorunda kalmadan web uygulamaları yazmamıza olanak tanır.
- Blazor'da eger console'a bir öğe yazdırmak istersek JS deki gibi `console.log()`değilde `Console.WrriteLine()`yazarak yazdırabiliriz.

## 3 Ways to Bind Blazor
en kullanışlı blazor özelliklerinden biri, `front DOM` öğelerimiz ile `back C#` kodu arasında veri aktarma yeteneğidir. 

Şimdi C# değişkenlerini, tarayıcıda görüntülenebilecek veya tarayıcıdaki kullanıcı girişi aracılığıyla değiştirilebilecek 
şekilde bağlama tekniklerini olan binding incelenecek.

 - One-way Data Binding
İlk teknik, bir değişkenin değerini web sitenizin DOM öğesine ekleyecek tek yönlü bir bağlantıdır.