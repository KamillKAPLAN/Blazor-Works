# PlannerApp

- https://www.youtube.com/playlist?list=PLFJQnCcZXWjtftgq0KID4oHk6wfJrRL1r kanalı ile geliştirilen uygulama
- **Radzen UI** Componentini kullanarak geliştirildi ve `https://blazor.radzen.com/` resmi sitesidir.

## Layout Tanımlama

Razor Kod Örneği (**AuthLayout.razor**): 

```C#
**@inherits LayoutComponentBase**

<div class="middle-box">
    <h1>Welcome to PlannerApp</h1>
    **@Body**
</div>
```

- layout'un uygulandığı sayfa (**Index.razor**)

```C#
@page "/"
**@layout AuthLayout**

<div class="row">
    <div class="col-12">
        <h3>Simple login</h3>
    </div>
</div>
<SurveyPrompt Title="How is Blazor working for you?" />

@code {
    
}
```