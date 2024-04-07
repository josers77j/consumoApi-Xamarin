# App Xamarin y API en asp.net core sdk 8

## Pasos

## Script sql necesario

    create database store;
    go;
    use store;
    go;
    create table products(
    id int primary key identity,
    product_name varchar(100),
    product_price decimal,
    product_stock int,
    product_status tinyint
    );
    go;
    insert into products values ('carrito',5,100,0);

## modificar archivo appsetting.json de ser necesario para ejecutar correctamente la API  

    "cadenaSQL": "Server=(local); DataBase=store;Integrated Security=True;TrustServerCertificate=True;Encrypt=False"

## modificar variable response en el archivo ApiService.cs en la carpeta Services dentro del proyecto xamarin de ser necesario

    var response = await client.GetStringAsync("http://10.0.2.2:5049/api/product/lista");

## Para finalizar, solo queda correr la api y luego la app xamarin

