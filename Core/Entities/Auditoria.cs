using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Core.Entities;
public class Auditoria : BaseEntity
{
    public string NombreUsuario;
    public long DescAccion;
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime FechaCreacion { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime FechaModificacion;

    public ICollection<BlockChain> blockChains { get; set; }

}