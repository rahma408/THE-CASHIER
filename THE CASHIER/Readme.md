# THE CASHIER
aplikasi ini mencangkup fungsi penghitungan kasir.barang yang diambil jumlahnya , harga dan total barang yg diambil.

## scope & functionalities
- user dapat memasukan jenis barang 

- user dapat memasukan angka 

- user dapat menambahkan barang dan harga barang dengan menyentuh tombol tambah

## how does it works ?
diawali dari method'mainwindow

'''c#

 public MainWindow()

        {
            InitializeComponent();
            calculator = new calculator();
            listBox.ItemsSource = calculator.getlisitem();
        }
'''penjelasan selanjutnya tentang class item yg menjelaskan tentang cara kerja item yg ada di aplikasi

'''c#

 public Item(int id, string title,int quantity, double price, double subtotal,string type)
 
       {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;
        }
''' penjelasan terahir ini tentang perhitungan caculatornya.yang terdapat di calculator.cs sebagai berikut.dan cara kerjanya masukan nama barang lalu pilih jasa atau barang masukan jumlah yg di pilih dan harga lalu tekan tombol tambah .

'''c#

 class calculator

    {
        private List<Item> listitem;
        private double total = 0;

        public calculator()
        {
            this.listitem = new List<Item>();
        }

        public void additem(Item item)
        {
            this.listitem.Add(item);
            this.total += item.getsubtotal();
        }

        public double gettotal()
        {
            return total;
        }

        public List<Item> getlisitem()
        {
            return listitem;
        }
    }

'''