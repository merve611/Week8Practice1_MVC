var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();     //hem view'leri hem de controller'lar� kullanabilmek i�in gerekli servisler eklendi

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//<link rel="stylesheet" href="/css/style.css"> olu�turulan wwwroot dosyas�na i�ine yaz�l�r

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();       //routing yap�land�rmas�n�

app.UseAuthorization();

app.MapControllerRoute(         //Anasayfa i�in varsay�lan routing yap�land�rmas�n�
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();



// Controller (Denetleyici ) : MVC de kullan�c�n�n isteklerini kar��lar. Gelen HTTP isteklerini al�r, ilgili i� mant���n� �al��t�r�r ve ard�ndan bir View veya veri d�nd�r�r.Controllerlar, kullan�c� aray�z� ve veri eri�im mant��� aras�ndaki k�pr� olarak g�rev yapar.

// Action (Eylem) : Action metodlar�, bir Controller i�inde yer al�r ve her biri belirli bir HTTP iste�ini i�ler. �rne�in, HomeController i�inde Index ad�nda bir Action metodu olabilir.Kullan�m amac�: Belirli bir HTTP iste�ini (GET, POST, vb.) kar��layan i�lemleri tan�mlar.

//Model : Model, uygulaman�n veri ve i� mant���n� temsil eder. Veritaban� ile ileti�im kuran veya i� mant���n� ta��yan nesnelerdir.

//View : View, kullan�c�ya sunulacak olan HTML i�eri�ini �retir. Viewlar, modelden gelen verilerle birlikte kullan�c�n�n g�rece�i aray�z� olu�turur. Kullan�c�ya g�sterilecek olan sayfa i�eri�ini �retir.

//Razor :  Razor, C# ve HTML'in birle�tirilmesine olanak sa�layan bir �ablonlama motorudur. Razor kullanarak, C# kodunu do�rudan HTML dosyalar� i�inde yazabilirsiniz. Sunucu tarafl� kodlamay� ve HTML ile birlikte kullan�lmas�n� sa�lar.

//RazorView : RazorView, Razor �ablonlar�n�n i�lendi�i ve kullan�c�ya d�nd�r�len HTML i�eri�ini olu�turan g�r�n�m dosyalar�d�r. Genellikle .cshtml uzant�s�na sahiptir.

//wwwroot :  wwwroot, ASP.NET Core uygulamalar�nda statik dosyalar�n (CSS, JavaScript, resimler vb.) bulundu�u k�k dizindir. Bu dosyalar do�rudan sunulabilir. Statik dosyalar�n sakland��� ve kullan�c�lara sunuldu�u yer.

//builder.Build()  : Program.cs dosyas�nda yer alan builder.Build() metodu, uygulaman�n yap�land�r�ld��� a�amay� tamamlar ve bir WebApplication nesnesi olu�turur. Bu nesne, uygulaman�n ya�am d�ng�s�n� y�netecek olan nesnedir. Uygulaman�n yap�land�rmas�n� tamamlar ve �al��t�r�labilir bir web uygulamas� olu�turur.

//app.Run()  :  app.Run() metodu, uygulamay� �al��t�r�r ve gelen HTTP isteklerini i�lemeye ba�lar. Bu metod �a�r�ld�ktan sonra, uygulama s�rekli olarak �al���r ve gelen istekleri bekler.

