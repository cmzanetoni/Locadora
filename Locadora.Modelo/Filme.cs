using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    [Table("Filmes")]
    public class Filme
    {
        [DisplayName("Código")]
        [Column(Order = 1)]
        public int Id { get; set; }

        [DisplayName("Título")]
        [Column(Order = 2)]
        [Required(ErrorMessage = "Título obrigatório")]
        [StringLength(200, ErrorMessage = "Máximo de 50 caracteres")]
        public string Titulo { get; set; }

        [DisplayName("Descrição")]
        [Column(Order = 6)]
        [StringLength(2000, ErrorMessage = "Máximo de 2000 caracteres")]
        public string Descricao { get; set; }

        [DisplayName("Lançamento")]
        [Column(Order = 3)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Data de lançamento obrigatório")]
        public DateTime DataLancamento { get; set; }

        [DisplayName("Valor da Locação")]
        [Column(Order = 4)]
        [Required(ErrorMessage = "Valor obrigatório obrigatório")]
        [DisplayFormat(DataFormatString = "{0:###,##0.00}", ApplyFormatInEditMode = true)]
        public double ValorLocacao { get; set; }

        [DisplayName("Valor de Venda")]
        [Column(Order = 5)]
        public double ValorVenda { get; set; }

        //[DisplayName("Primeiro Nome")]
        //[StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        //public string nome { get; set; }
        //[Required]
        //public string sobrenome { get; set; }
        //public string endereco { get; set; }
        //[StringLength(50)]
        //[Required(ErrorMessage = "Informe o Email")]
        //[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        //public string email { get; set; }
        //[DataType(DataType.Date)]
        //public DateTime nascimento { get; set; }
    }
 }
