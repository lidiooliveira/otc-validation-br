﻿
using Otc.Validations.Br.Annotations;

namespace AnnotationsSampleApp
{
    public class Model
    {
        [CpfAttribute(ErrorKey = "400.001", ErrorMessage = "Cpf do Cliente inválido.")]
        public string Cpf { get; set; }
    }
}
