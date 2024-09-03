var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();     //hem view'leri hem de controller'larý kullanabilmek için gerekli servisler eklendi

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//<link rel="stylesheet" href="/css/style.css"> oluþturulan wwwroot dosyasýna içine yazýlýr

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();       //routing yapýlandýrmasýný

app.UseAuthorization();

app.MapControllerRoute(         //Anasayfa için varsayýlan routing yapýlandýrmasýný
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



// Controller (Denetleyici ) : MVC de kullanýcýnýn isteklerini karþýlar. Gelen HTTP isteklerini alýr, ilgili iþ mantýðýný çalýþtýrýr ve ardýndan bir View veya veri döndürür.Controllerlar, kullanýcý arayüzü ve veri eriþim mantýðý arasýndaki köprü olarak görev yapar.

// Action (Eylem) : Action metodlarý, bir Controller içinde yer alýr ve her biri belirli bir HTTP isteðini iþler. Örneðin, HomeController içinde Index adýnda bir Action metodu olabilir.Kullaným amacý: Belirli bir HTTP isteðini (GET, POST, vb.) karþýlayan iþlemleri tanýmlar.

//Model : Model, uygulamanýn veri ve iþ mantýðýný temsil eder. Veritabaný ile iletiþim kuran veya iþ mantýðýný taþýyan nesnelerdir.

//View : View, kullanýcýya sunulacak olan HTML içeriðini üretir. Viewlar, modelden gelen verilerle birlikte kullanýcýnýn göreceði arayüzü oluþturur. Kullanýcýya gösterilecek olan sayfa içeriðini üretir.

//Razor :  Razor, C# ve HTML'in birleþtirilmesine olanak saðlayan bir þablonlama motorudur. Razor kullanarak, C# kodunu doðrudan HTML dosyalarý içinde yazabilirsiniz. Sunucu taraflý kodlamayý ve HTML ile birlikte kullanýlmasýný saðlar.

//RazorView : RazorView, Razor þablonlarýnýn iþlendiði ve kullanýcýya döndürülen HTML içeriðini oluþturan görünüm dosyalarýdýr. Genellikle .cshtml uzantýsýna sahiptir.

//wwwroot :  wwwroot, ASP.NET Core uygulamalarýnda statik dosyalarýn (CSS, JavaScript, resimler vb.) bulunduðu kök dizindir. Bu dosyalar doðrudan sunulabilir. Statik dosyalarýn saklandýðý ve kullanýcýlara sunulduðu yer.

//builder.Build()  : Program.cs dosyasýnda yer alan builder.Build() metodu, uygulamanýn yapýlandýrýldýðý aþamayý tamamlar ve bir WebApplication nesnesi oluþturur. Bu nesne, uygulamanýn yaþam döngüsünü yönetecek olan nesnedir. Uygulamanýn yapýlandýrmasýný tamamlar ve çalýþtýrýlabilir bir web uygulamasý oluþturur.

//app.Run()  :  app.Run() metodu, uygulamayý çalýþtýrýr ve gelen HTTP isteklerini iþlemeye baþlar. Bu metod çaðrýldýktan sonra, uygulama sürekli olarak çalýþýr ve gelen istekleri bekler.

