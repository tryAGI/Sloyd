#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EditObjectRequest : global::System.IEquatable<EditObjectRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Sloyd.CreateObjectRequest? Create { get; init; }
#else
        public global::Sloyd.CreateObjectRequest? Create { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Sloyd.EditObjectRequestVariant2? EditObjectRequestVariant2 { get; init; }
#else
        public global::Sloyd.EditObjectRequestVariant2? EditObjectRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EditObjectRequestVariant2))]
#endif
        public bool IsEditObjectRequestVariant2 => EditObjectRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EditObjectRequest(global::Sloyd.CreateObjectRequest value) => new EditObjectRequest((global::Sloyd.CreateObjectRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Sloyd.CreateObjectRequest?(EditObjectRequest @this) => @this.Create;

        /// <summary>
        /// 
        /// </summary>
        public EditObjectRequest(global::Sloyd.CreateObjectRequest? value)
        {
            Create = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EditObjectRequest(global::Sloyd.EditObjectRequestVariant2 value) => new EditObjectRequest((global::Sloyd.EditObjectRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Sloyd.EditObjectRequestVariant2?(EditObjectRequest @this) => @this.EditObjectRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EditObjectRequest(global::Sloyd.EditObjectRequestVariant2? value)
        {
            EditObjectRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EditObjectRequest(
            global::Sloyd.CreateObjectRequest? create,
            global::Sloyd.EditObjectRequestVariant2? editObjectRequestVariant2
            )
        {
            Create = create;
            EditObjectRequestVariant2 = editObjectRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EditObjectRequestVariant2 as object ??
            Create as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Create?.ToString() ??
            EditObjectRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreate && IsEditObjectRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Sloyd.CreateObjectRequest?, TResult>? create = null,
            global::System.Func<global::Sloyd.EditObjectRequestVariant2?, TResult>? editObjectRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate && create != null)
            {
                return create(Create!);
            }
            else if (IsEditObjectRequestVariant2 && editObjectRequestVariant2 != null)
            {
                return editObjectRequestVariant2(EditObjectRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Sloyd.CreateObjectRequest?>? create = null,
            global::System.Action<global::Sloyd.EditObjectRequestVariant2?>? editObjectRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsEditObjectRequestVariant2)
            {
                editObjectRequestVariant2?.Invoke(EditObjectRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Create,
                typeof(global::Sloyd.CreateObjectRequest),
                EditObjectRequestVariant2,
                typeof(global::Sloyd.EditObjectRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EditObjectRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Sloyd.CreateObjectRequest?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::Sloyd.EditObjectRequestVariant2?>.Default.Equals(EditObjectRequestVariant2, other.EditObjectRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EditObjectRequest obj1, EditObjectRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EditObjectRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EditObjectRequest obj1, EditObjectRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EditObjectRequest o && Equals(o);
        }
    }
}
