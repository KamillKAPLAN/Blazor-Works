# BlazorLearn

- Blazor WebAssembly, JavaScript öğrenmek veya kullanmak zorunda kalmadan web uygulamaları yazmamıza olanak tanır.
- Blazor'da eger console'a bir öğe yazdırmak istersek JS deki gibi `console.log()`değilde `Console.WrriteLine()`yazarak yazdırabiliriz.

## 3 Ways to Bind Blazor
en kullanışlı blazor özelliklerinden biri, `front DOM` öğelerimiz ile `back C#` kodu arasında veri aktarma yeteneğidir. 

Şimdi C# değişkenlerini, tarayıcıda görüntülenebilecek veya tarayıcıdaki kullanıcı girişi aracılığıyla değiştirilebilecek 
şekilde bağlama tekniklerini olan binding incelenecek.

 - `One-way Data Binding`
İlk teknik, bir değişkenin değerini web sitenizin DOM öğesine ekleyecek tek yönlü bir bağlantıdır.

<h6>Greetings, @userName</h6>

@code {
    string userName = "Bradley";
}

 - `click-way Data Binding`

<h6>Greetings, @userName</h6>

<button class="btn btn-primary" @onclick="ToggleName">Change Name</button>

@code {
    string userName = "Bradley";
    void ToggleName()
    {
        if (userName == "Bradley")
            userName = "Mr. Wells";
        else
            userName = "Bradley";
    }
}

 - `Two-way Data Binding

## validation (doğrulama) : bir value'nin alanları için çeşitli kontrollerinin yapılması. 

- Validation bizim nesnemizin iş kurallarına dahil etmek için 
uygun olup olmadığını yapısal olarak belirlediğimiz noktadır. 
Tamamen nesnenin yapısı ile ilgilenir.

## models (folder) : bizim aslında arayüzde kullanıcıya gösterdiğimiz, o arayüzü ilgilendiren yapının ta kendisidir. 

- Bir ürün ekleme sayfasında o ürüne ait bilgiler bizim modelimizi anlatır. 

- model aslında bir `Encapsulation` OOP tekniğidir.

- model aslında bizim ekran `classlarımızdır`.

- Blazor'ın .NET destekli olmasının `Data Annotation` özelliğinden yararlanmamıza olanak sağlar.

## Data Annotation : bizim model nesnelerimizin üzerine bir `attribute` vasıtasıyla kurallar koyma yöntemidir.

- validation'ı kullanabilmek için blazordan gelen hazır component'leri kullanmamız gerekmektedir.