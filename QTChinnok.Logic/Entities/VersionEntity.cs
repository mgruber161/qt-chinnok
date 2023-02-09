﻿//@CodeCopy
//MdStart
namespace QTChinnok.Logic.Entities
{
    using Logic.Contracts;
    public abstract partial class VersionEntity : EntityObject, IVersionable
    {
#if ROWVERSION_ON
        /// <summary>
        /// Row version of the entity.
        /// </summary>
        [Timestamp]
        public byte[]? RowVersion { get; internal set; }
#endif
    }
}
//MdEnd
