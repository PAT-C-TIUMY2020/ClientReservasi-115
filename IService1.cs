using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JumlahPemesanan, string IDLokasi);//method proses input data

        [OperationContract]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon);

        [OperationContract]
        string deletePemesanan(string IDPemesanan);

        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //nampilin data yang ada di database (select all) menampilkan isi dari yang ada contract

        [OperationContract]
        List<DetailLokasi> DetailLokasi();

        [OperationContract]
        List<Pemesanan> Pemesanan();
        string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    public class CekLokasi //daftar lokasi nongrong
    {
    
        public string IDLokasi { get; set; } //variable dari public class

   
        public string NamaLokasi { get; set; }


        public string DeskripsiSingkat { get; set; }
    }


    public class DetailLokasi //menampilkan detail lokasi
    {
      
        public string IDLokasi { get; set; } //variable dari public class

       
        public string NamaLokasi { get; set; }

        public string DeskripsiFull { get; set; }

    
        public int Kouta { get; set; }
    }



    public class Pemesanan //crate
    {
 
        public string IDPemesanan { get; set; } //variable dari public class


        public string NamaCustomer { get; set; } // method

    
        public string NoTelepon { get; set; }


        public int JumlahPemesanan { get; set; }


        public string Lokasi { get; set; }
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceReservasi.ContractType".
    /*[DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }
        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}
