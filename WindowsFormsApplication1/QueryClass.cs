using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class QueryClass
    {
        public static bool ValidateUser(UserInformation _user)
        {

            string query = "Select * From LoginPanel Where Username='" + _user.Usrename.ToUpper() + "' and Password='" + _user.Password.ToUpper() + "'  ";

            try
            {
                DataTable _dtable = null;
                _dtable = dbAccess.ReadDataFromDb(query);

                if (_dtable.Rows.Count > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            { throw ex; }

        }







        //Insert
        public static void InsertData(ExpenseClass stock)
        {

            string query = "INSERT INTO ExpenseTable (ExpenseName, ExpenseRS, Date ) VALUES('" + stock.Nameexpense.ToUpper() + "','" + stock.Rupees.ToUpper() + "','" + stock.Date + "' );";

            try
            {
                DataTable _dtable = null;

                _dtable = dbAccess.ReadDataFromDb(query);



            }
            catch (Exception ex)
            { throw ex; }

        } //End Of Insert Function








        //Delete
        public static void DeleteData(ExpenseClass sale)
        {

            string query = "Delete From ExpenseTable Where ExpenseName='" + sale.Nameexpense.ToUpper() + "' and Date='" + sale.Date.ToUpper() + "'";

            try
            {
                DataTable _dTable = null;

                _dTable = dbAccess.ReadDataFromDb(query);




            }
            catch (Exception ex)
            { throw ex; }

        } //End Of delete Function







        public static void InsertData(BuyItemClass stock)
        {

            string query = "INSERT INTO BuyItemTable (Name, Quantity, Expiry ) VALUES('" + stock.Name.ToUpper() + "','" + stock.Quantity.ToUpper() + "','" + stock.Expiry + "' );";

            try
            {
                DataTable _dtable = null;

                _dtable = dbAccess.ReadDataFromDb(query);



            }
            catch (Exception ex)
            { throw ex; }

        } //End Of Insert Function
          public static void DeleteData(BuyItemClass sale)
        {

            string query = "Delete From BuyItemTable Where Name='" + sale.Name.ToUpper() + "' and Expiry='" + sale.Expiry.ToUpper() + "'";

            try
            {
                DataTable _dTable = null;

                _dTable = dbAccess.ReadDataFromDb(query);




            }
            catch (Exception ex)
            { throw ex; }

        } //End Of delete Function

          public static void InsertData(CompanyInformationClass stock)
          {

              string query = "INSERT INTO CompanyInfoTable (CompanyName, CompanyAdd, CompanyNumber1,CompanyNumber2 ) VALUES('" + stock.Name.ToUpper() + "','" + stock.Address.ToUpper() + "','" + stock.PhoneNo + "','" + stock.Cell + "' );";
              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);
              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function

          public static void InsertData(InvoiceInfoClass stock)
          {

              string query = "INSERT INTO InvoiceTable (CustomerName, InvoiceNumber, Date ) VALUES('" + stock.CustomerName.ToUpper() + "','" + stock.Invoice + "','" + stock.Date + "' );";

              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);
              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function
          public static void InsertData(InvoiceProductClass stock)
          {

              string query = "INSERT INTO InvoiceProductTable (ProductId, ProductQuantity, Total ) VALUES('" + stock.ProductId.ToUpper() + "','" + stock.Quantity.ToUpper() + "','" + stock.Totel + "' );";

              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);
              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function
          public static void InsertData(OTClass stock)
          {

              string query = "INSERT INTO OrderTakerDemandTable (ProductName, Quantity ) VALUES('" + stock.Name.ToUpper() + "','" + stock.Quantity.ToUpper() + "');";

              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);



              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function
          public static void InsertData(OTInfoclass stock)
          {

              string query = "INSERT INTO OrderTakerInfoTable (OrderTakerName,OrderTakerCompany,OrderTakerNumber ) VALUES('" + stock.Name.ToUpper() + "','" + stock.CompanyName.ToUpper() +"','" + stock.CompanyNumber.ToUpper() +"');";

              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);



              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function
          public static void InsertData(SalesManInfoClass stock)
          {

              string query = "INSERT INTO SalesManTable (SalesmanName,SalesmanQualification,SalesmanCity,SalesmanPhoneNumber ) VALUES('" + stock.Name.ToUpper() + "','" + stock.Qualification.ToUpper() + "','" + stock.City.ToUpper() + "' ,'" + stock.Number + "');";

              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);



              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function
          public static void InsertData(ProductClass stock)
          {

              string query = "INSERT INTO ProductFormTable (CompanyID,ProductName,ProductCatagory,ProductPurchasePrice,ProductSalePrice,Packing ) VALUES('" + stock.Name.ToUpper() + "','" + stock.Company.ToUpper() + "' ,'" + stock.Catagory + "','" + stock.Purchaseprice + "','"+ stock.Saleprice + "','" + stock.Packing + "');";

              try
              {
                  DataTable _dtable = null;

                  _dtable = dbAccess.ReadDataFromDb(query);



              }
              catch (Exception ex)
              { throw ex; }

          } //End Of Insert Function

          public static void DeleteData(ProductClass sale)
          {

              string query = "Delete From ProductFormTable Where ProductName='" + sale.Name.ToUpper() + "' and ProductSaleRate='" + sale.Saleprice.ToUpper() + "'";

              try
              {
                  DataTable _dTable = null;

                  _dTable = dbAccess.ReadDataFromDb(query);




              }
              catch (Exception ex)
              { throw ex; }

          } //End Of delete Function
          public static void DeleteData(CompanyInformationClass sale)
          {

              string query = "Delete From CompanyInfoTable Where CompanyName='" + sale.Name.ToUpper() + "' and CompanyAdd='" + sale.Address.ToUpper() + "'";

              try
              {
                  DataTable _dTable = null;

                  _dTable = dbAccess.ReadDataFromDb(query);




              }
              catch (Exception ex)
              { throw ex; }

          } //End Of delete Function
    }

}

