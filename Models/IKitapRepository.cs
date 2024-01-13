namespace Library.Models
{
    public interface IKitapRepository:IRepository<Kitap>
    {
        void Guncelle(KitapTuru kitapTuru);
        void Guncelle(Kitap kitap);
        void Kaydet();
    }
}
