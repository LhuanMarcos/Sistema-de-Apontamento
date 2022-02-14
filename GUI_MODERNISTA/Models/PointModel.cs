using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;
using System.IO;
using GUI_PONTO;
using GUI_PONTO.Controller;
using GUI_MODERNISTA.Entities;

namespace POINT.Models
{
	

	public class PointModel
	{

        PointController pointController = new();
        PointC point = new();

        //inserir pontos do banco
        public string InsertInToPointsFrmModel(PointC p)
        {
            try
            {

               return pointController.InsertoPointInToDataBaseFromController(p);
             
            }
            catch (Exception)
            {

                throw;
            }
        }

        //inserir tamplate no banco
        public DataTable InsertTemplateInToDatabaseModel(string textFir, string user_RE)
        {
            try
            {
                DataTable dt = new();
                dt = pointController.InsertTemplateInToDatabaseController(textFir, user_RE);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Alterar marcação de ´ponto no banco de dados
        public DataTable UpdatePointInToDataBaseFromModel(PointC p)
        {
            try
            {
                DataTable dt = new();
                dt =  pointController.UpdatePointInToDataBaseFromController(p);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }

        }

            //pegar template do user
            public DataTable GetuserTemplateModel()
        {
            try
            {
                DataTable dt = new();
                dt = pointController.GetuserTemplateController();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //busca a marcação de ponto do dia por re
        public DataTable TimestampSearchByReFromModel(string user_re)
        {
            try
            {
                DataTable dt = new();
                dt = pointController.TimestampSearchByRe(user_re);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //busca do re por id
        public string ReturnUserReFromModel(int user_id)
        {
            try
            {
             
              return pointController.ReturnUserRe(user_id);
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Lista de batida de ponto do usuario
        public DataTable SearchByUserReFormModel(PointC point)
        {
            try
            {
                DataTable dt = pointController.SearchByUserReFormController(point);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }



        #region LOGIN DE USUÁRIO
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {         
            return userDao.Login(user, pass);
        }
        #endregion
    }
}
