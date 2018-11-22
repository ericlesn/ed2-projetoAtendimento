using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dtGerac;
        private DateTime horaGerac;
        private DateTime dtAtend;
        private DateTime horaAtend;

        #region Propriedades
        public DateTime DtGerac
        {
            get
            {
                return dtGerac;
            }

            set
            {
                dtGerac = value;
            }
        }

        public DateTime HoraGerac
        {
            get
            {
                return horaGerac;
            }

            set
            {
                horaGerac = value;
            }
        }

        public DateTime DtAtend
        {
            get
            {
                return dtAtend;
            }

            set
            {
                dtAtend = value;
            }
        }

        public DateTime HoraAtend
        {
            get
            {
                return horaAtend;
            }

            set
            {
                horaAtend = value;
            }
        }
        #endregion
        public Senha(int id)
        {
            this.DtGerac = DateTime.Now;
            this.HoraGerac = DateTime.Now;
            this.DtAtend = new DateTime(0);
            this.HoraAtend = new DateTime(0);
            this.id = id;
        }

        public string dadosParciais()
        {
            return this.id + " - " + this.DtGerac.ToShortDateString() + " - " + this.HoraGerac.ToLongTimeString();
        }

        public string dadosCompletos()
        {
            return this.dadosParciais() + " - " + this.DtAtend.ToShortDateString() + " - " + this.HoraAtend.ToLongTimeString();
        }
    }
}
