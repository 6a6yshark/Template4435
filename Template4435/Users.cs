//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template4435
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Last_ent { get; set; }
        public string Type_ent { get; set; }

        internal static object GroupBy(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
