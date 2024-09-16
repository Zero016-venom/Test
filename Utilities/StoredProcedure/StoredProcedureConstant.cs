﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.StoredProcedure
{
    public class StoredProcedureConstant
    {
        //Tất cả các SP sẽ được khai báo tại đây để quản lí
        public const string EXAMPLE = "SP_Name";
        public const string Continetal = "Data Source=.;Initial Catalog=Conentinal;Integrated Security=True;Trust Server Certificate=True";
        //service type
        public const string SP_InsertServiceType = "SP_InsertServiceType";
        public const string SP_UpdateServiceType = "SP_UpdateServiceType";
        public const string SP_DeleteServiceType = "SP_DeleteServiceType";
        public const string SP_GetListServiceType = "SP_GetListServiceType";
        //service
        public const string SP_InsertService = "SP_InsertService";
        public const string SP_GetListService = "SP_GetListService";
        public const string SP_DeleteService = "SP_DeleteService";
        public const string SP_GetServiceById = "SP_GetServiceById";
        public const string SP_UpdateService = "SP_UpdateService";

    }
}
