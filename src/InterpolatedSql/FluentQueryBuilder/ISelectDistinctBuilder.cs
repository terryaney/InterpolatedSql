﻿using System;

namespace InterpolatedSql.FluentQueryBuilder
{
    /// <summary>
    /// QueryBuilder which is preparing a SELECT DISTINCT statement
    /// </summary>
    public interface ISelectDistinctBuilder<T>
        
        where T : IFluentQueryBuilder<T>
    {
        /// <summary>
        /// Adds one column to the select clauses, and defines that query is a SELECT DISTINCT type
        /// </summary>
        ISelectDistinctBuilder<T> SelectDistinct(FormattableString select);

        /// <summary>
        /// Adds one or more columns to the select clauses, and defines that query is a SELECT DISTINCT type
        /// </summary>
        ISelectDistinctBuilder<T> SelectDistinct(params FormattableString[] moreColumns);


        /// <summary>
        /// Adds a new table to from clauses. <br />
        /// "FROM" word is optional. <br />
        /// You can add an alias after table name. <br />
        /// You can also add INNER JOIN, LEFT JOIN, etc (with the matching conditions).
        /// </summary>
        IFromBuilder<T> From(FormattableString from);
    }
}
