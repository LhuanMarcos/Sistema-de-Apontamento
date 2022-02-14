using GUI_PONTO.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_PONTO.Entities;

namespace GUI_PONTO.Models
{
    public class JustificationCategoryModel
    {

        JustificationCategoryController jusController = new();

        //Listagem de Cateegorias
        public DataTable CategoryListGridModel(int status)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = jusController.CategoryListGridController(status);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Listagem de Categorias de justficativas para combobox
        public DataTable JustificationCategoryCombobox()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = jusController.JustificationCategoryCombobox();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
       

        //Busca de Categorias por status e nome 
        public DataTable CategoryListGridByJustificationAndNameModel(JustificationCategory cate)
        {
            DataTable dt= new();
            dt = jusController.CategoryListGridByJustificationAndNameController(cate);
            return dt;
        }

        public DataTable CategoryUpdateFromModel(JustificationCategory cate)
        {
            DataTable dt = new();
            dt = jusController.CategoryUpdateFromController(cate);
            return dt;
        }

        //Inserir dados no banco categoria
        public void InsertCategoryInToDataBase(JustificationCategory cate)
        {           
            jusController.InsertCategoryInToDataBase(cate);      
        }





    }
}
