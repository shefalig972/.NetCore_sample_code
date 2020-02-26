﻿//------------------------------------------------------------------------------
// <autogenerated>
//     
//       Changes to this template will not be lost.
//
//     Template: DTO.cst
//     
// </autogenerated>
//------------------------------------------------------------------------------
using System;

 

namespace CFMData
{    
    /// <summary>
    /// The BankAccountCard class is a CSLA editable root class.  See CSLA documentation for a more detailed description.
    /// </summary>
    public partial class BankAccountCardDTO
    {
        public BankAccountCard CustomCopyDTO(BankAccountCard obj)
        {

            obj.BankAccountCardID = this.BankAccountCardID;
            obj.BankAccountID = this.BankAccountID;
            obj.CardNumber = this.CardNumber;
            obj.ExpDate = this.ExpDate;
            obj.HeldByStaffID = this.HeldByStaffID;
            obj.HeldFrom = this.HeldFrom;
            obj.HeldTo = this.HeldTo;
            obj.IsActive = this.IsActive;
 
            return obj;
        }
  }
}