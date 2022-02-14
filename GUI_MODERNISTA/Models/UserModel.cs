using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_MODERNISTA.Controller;
using System.Data;
using System.Windows.Forms;
using GUI_MODERNISTA.Entities;
using GUI_PONTO.Controller;
using GUI_PONTO.Entities;

namespace GUI_MODERNISTA.Models
{
    
    public class UserModel
    {
        UserController userController = new UserController();

        //listagem de user
        public DataTable UserListModel(User user)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = userController.UserListController(user);
                return dt;
            }
            catch (Exception)
            {
                 throw;
            }
        }
        //Listagem para combobox
            public DataTable UserListCombo()
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = userController.UserListCombo();
                    return dt;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
            //save
            public int UserSaveModel(User dado)
        {
            UserController userController = new UserController();
            try
            {
                return userController.userSaveController(dado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //alteração 
        public void UserUpdateModel(User user)
        {
            UserController userController = new UserController();
            try
            {
                 userController.UserUpdateController(user);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //salvar endereço 
        public void addresUserSaveModel(Addres addres)                                
        {
            UserController userController = new UserController();
            try
            {
                userController.addresSaveController(addres);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //alterar dados de endereço
        public void addresUserEditModel(Addres addres)
        {
            UserController userController = new UserController();
            try
            {
                userController.AddresUpdateController(addres);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }

}
