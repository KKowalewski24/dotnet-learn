using System.ComponentModel.DataAnnotations;

namespace EFCoreWebApi.Models {

    public abstract class BaseEntity {

        /*------------------------ FIELDS REGION ------------------------*/
        [Key]
        public long Id { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        protected BaseEntity() {
        }

        public override string ToString() {
            return $"{nameof(Id)}: {Id}";
        }

    }

}
