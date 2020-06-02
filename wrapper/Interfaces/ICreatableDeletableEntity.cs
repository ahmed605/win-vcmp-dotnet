using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This class represents an entity that can be created and deleted by the server.
    /// </summary>
    public interface ICreatableDeletableEntity {
        /// <summary>
        /// Whether this entity is currently created or not. This property can be used to
        /// temporarily delete this entity and then recreate it in its previous state when needed.
        ///
        /// To permanently delete this entity, set this property to <c>false</c> and remove all
        /// references to this entity.
        /// </summary>
        bool IsCreated {
            get;
            set;
        }
    }
}
