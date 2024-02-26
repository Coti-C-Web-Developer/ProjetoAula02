using System.Text.RegularExpressions;

namespace ProjetoAula02.Entities
{
    /// <summary>
    /// Classe de modelo de dados de Funcionário
    /// </summary>
    public class Funcionario : Pessoa
    {
        #region Atributos

        private string? _matricula;
        private DateTime? _dataAdmissao;
        private decimal? _salario;

        #endregion


        #region Propriedades

        public string? Matricula
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Por favor, informe a matrícula.");

                var regex = new Regex("^[A-Z0-9]{4,10}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe uma matrícula válida.");

                _matricula = value;
            }
            get => _matricula;
        }

        public DateTime? DataAdmissao
        {
            set => _dataAdmissao = value;
            get => _dataAdmissao;
        }

        public decimal? Salario
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O salário deve ser maior do que zero.");

                _salario = value;
            }
            get => _salario;
        }

        #endregion
    }
}
