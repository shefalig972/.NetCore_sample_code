﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: EditableRoot.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;


namespace CFMData
{    
    /// <summary>
    /// The MailingTemplate class is a editable root class.
    /// </summary>
    public partial class MailingTemplate
    {
        #region Business Rules
    
        /// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
        protected bool AddBusinessValidationRules()
        {
            // TODO: add validation rules
            //BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(MyProperty));

            return false;
        }

    #endregion

   

    public MailingTemplate CustomSave()
    {
      bool cancel = false;
      OnUpdating(ref cancel);
     
        using (var connection = new SqlConnection(ADOHelper.ConnectionString))
      {
        connection.Open();
        using (var command = new SqlCommand("[dbo].[spCFM_MailingTemplate_Update]", connection))
        {
          command.CommandType = CommandType.StoredProcedure;
          command.Parameters.AddWithValue("@p_OriginalMailingTemplateID", this.MailingTemplateID);
          command.Parameters.AddWithValue("@p_MailingTemplateID", this.MailingTemplateID);
          command.Parameters.AddWithValue("@p_Description", ADOHelper.NullCheck(this.Description));
          command.Parameters.AddWithValue("@p_MailingText", ADOHelper.NullCheck(this.MailingText));
          command.Parameters.AddWithValue("@p_MailingSubject", ADOHelper.NullCheck(this.MailingSubject));
          command.Parameters.AddWithValue("@p_MailingFrom", ADOHelper.NullCheck(this.MailingFrom));
          command.Parameters.AddWithValue("@p_CreatedBy", this.CreatedBy);
          command.Parameters.AddWithValue("@p_CreatedOn", this.CreatedOn);
          command.Parameters.AddWithValue("@p_UpdatedBy", ADOHelper.NullCheck(this.UpdatedBy));
          command.Parameters.AddWithValue("@p_UpdatedOn", ADOHelper.NullCheck(this.UpdatedOn));
          //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
          int result = command.ExecuteNonQuery();
          if (result == 0)
            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

          _originalMailingTemplateIDProperty = this.MailingTemplateID;
        }
       
      }

      OnUpdated();
      return this;
    }



  }
}