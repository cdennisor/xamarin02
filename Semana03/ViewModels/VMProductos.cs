using Semana03.Models;
using System.Collections.ObjectModel;

namespace Semana03.ViewModels
{
    public class VMProductos
    {
        public ObservableCollection<MProductos> MyProducts { get; set; }
        public ObservableCollection<MProductos> MyOffers { get; set; }
        public ObservableCollection<MProductos> MyCategory { get; set; }
        public VMProductos()
        {
            MyProducts = new ObservableCollection<MProductos>
            {
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Price=1699.99, Name="Computadora Completa"},
                new MProductos{
                    Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGpbxZQ0F7pr20lz2Wz3WVpaVwS0eDB1nLug&s",
                    Price=1699.99, Name="Mas Gamer Inalámbrico + Mouse Pad"},
                new MProductos{
                    Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSyTO0UY_ebhfSH8lVqfY2LNXZ07axny4r8eA&s",
                    Price=1699.99, Name="Laptop Gaming Azuz 32Ram", Description="Envio gratis"},
                new MProductos{
                    Img="https://http2.mlstatic.com/D_NQ_NP_836853-MLU71967177594_092023-O.webp",
                    Price=1699.99, Name="Super Teclado Mecánico Gamer", Description="Envio ratis"},
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Price=1699.99, Name="Computadora 1", Description="Envio gratis"},
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Price=1699.99, Name="Computadora 1", Description="Envio gratis"},
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Price=1699.99, Name="Computadora 1", Description="Envio gratis"}
            };

            MyOffers = new ObservableCollection<MProductos>
            {
                new MProductos{
                    Img="https://http2.mlstatic.com/D_NQ_NP_770084-MLU75011983773_032024-O.webp",
                    Discount="278",
                    Price=100, Name="Disco Sólido Ssd Interno Kingston Nv2 Snv2s/1tb", Description="Envío gratis"},
                new MProductos{
                    Img="https://http2.mlstatic.com/D_NQ_NP_842879-MLA75054704855_032024-O.webp",
                    Discount="305",
                    Price=230, Name="Control Joystick Inalámbrico Dualsense Ps5 Cobalt Blue", Description="Envío gratis"},
                new MProductos{
                    Img="https://http2.mlstatic.com/D_NQ_NP_803598-MPE77547527021_072024-O.webp",
                    Discount="99.90",
                    Price=69, Name="Zapatillas Urbanas Soul Beige North Star Hombre V2 S3", Description="Envío gratis"},
                new MProductos{
                    Img="https://http2.mlstatic.com/D_NQ_NP_836853-MLU71967177594_092023-O.webp",
                    Discount="1800",
                    Price=1699.99, Name="Computadora 1"},
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Discount="1800",
                    Price=1699.99, Name="Computadora 1"},
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Discount="1800",
                    Price=1699.99, Name="Computadora 1"},
                new MProductos{
                    Img="https://cdnx.jumpseller.com/motics/image/26850753/MONITOR_DE_19.png?1662502183",
                    Discount="1800",
                    Price=1699.99, Name="Computadora 1"}
            };

            MyCategory = new ObservableCollection<MProductos>
            {
                new MProductos{Img="https://i0.wp.com/www.tecnosmart.com.ec/wp-content/uploads/2021/08/Pc-Gamer.png?fit=376%2C376&ssl=1", Category="Computadoras"},
                new MProductos{Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSPc7nWREdPOSahopNjIRlwWRywiA7Un72QFg&s", Category="Electrodomésticos"},
                new MProductos{Img="https://img.freepik.com/vector-gratis/conjunto-ropa-verano_74855-446.jpg", Category="Ropa y moda"},
                new MProductos{Img="https://static.wixstatic.com/media/ace57a_efce4b2bb07e41c9bdd00a00a5ee3f48~mv2.jpg", Category="Artículos de limpieza"},
                new MProductos{Img="https://img.freepik.com/vector-gratis/conjunto-ilustraciones-planas-zapatos-femeninos-al-azar-calzado-verano-otono-e-invierno-mujer-mocasines-botas-zapatillas-tacones-aislados-blanco_74855-20699.jpg", Category="Calzados"},
                new MProductos{Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQERXlBGnuW7_v-oPXuqHLDDvQFc6C9LvM1w&s", Category="Maquillaje"},
                new MProductos{Img="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZbeoDkyrdzXh_mTfNF7MqZKUnx7f-826xa6tkph3IqBvNMSWjqrUiHnaxNArJI2APswM&usqp=CAU", Category="deporte"}
            };
        }
    }
}
