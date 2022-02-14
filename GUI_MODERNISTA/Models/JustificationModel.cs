using GUI_MODERNISTA.Entities;
using GUI_PONTO.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Models
{
    public class JustificationModel
    {
        JustificationController justification = new JustificationController();

        //Preencher gridview justificativas
        public DataTable JustificationListGridModel(int status)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = justification.JustificationListGridController(status);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

         //Busca de justificativas por nome e status
        public DataTable JustificationListGridModel(Justification jus)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = justification.RoleListGridByJustificationAndNameController(jus);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Vincular Categoria com justificativa

        public void LinkJustificationInToDatabaseModel(int category_id, int justification_id)
        {
            try
            {
                justification.LinkJustificationInToDatabase(category_id, justification_id);
     
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Inserir dados na tabela de Justification
        public int InsertJustificationToDataBaseFromModel(Justification Just)
        {
            try
            {
                return justification.InsertjustificationInToDataBase(Just);
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Preencher combobox de justificativas
        public DataTable JustificationListGridCombobox()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = justification.JustificationListGridCombobox();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        //fazer update de Justificativas
        public DataTable JustificationUpdateFromModel(Justification just)
        {
            DataTable dt = new();
            dt = justification.JustificationUpdateFromController(just);
            return dt;
        }

    }
}
