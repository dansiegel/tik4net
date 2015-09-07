﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tik4net.Objects
{
    /// <summary>
    /// Attribute that is used to decorate tik entity class.
    /// </summary>
    /// <seealso cref="TikConnectionExtensions"/>
    /// <seealso cref="TikEntityObjectsExtensions"/>
    /// <seealso cref="TikEntityAttribute"/>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TikEntityAttribute : Attribute
    {
        /// <summary>
        /// Gets the entity path in API notation (/ip/firewall/mangle).
        /// </summary>
        /// <value>The entity path.</value>
        public string EntityPath { get; private set; }

        /// <summary>
        /// If the whole entity is R/O.
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// If entity should be loaded with =detail= option.
        /// </summary>
        public bool IncludeDetails { get; set; }

        /// <summary>
        /// If entity fields should be listed explicitly via .proplist option.
        /// </summary>
        public bool IncludeProplist { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TikEntityAttribute"/> class.
        /// </summary>
        /// <param name="entityPath">The entity path in API notation (/ip/firewall/mangle).</param>
        public TikEntityAttribute(string entityPath, bool isReadOnly, bool includeDetails)
        {
            Guard.ArgumentNotNullOrEmptyString(entityPath, "entityPath");
            EntityPath = entityPath;
            IsReadOnly = isReadOnly;
            IncludeDetails = includeDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TikEntityAttribute"/> class. ReadOnly = false, IncludeDetails=false.
        /// </summary>
        /// <param name="entityPath">The entity path in API notation (/ip/firewall/mangle).</param>
        public TikEntityAttribute(string entityPath)
        {
            Guard.ArgumentNotNullOrEmptyString(entityPath, "entityPath");
            EntityPath = entityPath;

            IsReadOnly = false;
            IncludeDetails = false;
            IncludeProplist = false;
        }
    }

}