using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlyginimo_Skaiciavimo_Sistema
{
    class MokesciaiAntPop
    {
        private double atlyginimas;
        private double _NPD;
        private double _PM;
        private double _SSD;
        private double _Sodra;
        private double _DBVK;
        private double _SPSD;

        public double SPSD
        {
            get
            {
                return _SPSD;
            }
        }
        public double SSD
        {
            get
            {
                return _SSD;
            }
        }
        public double Sodra
        {
            get
            {
                return _Sodra;
            }
        }
        public double DBVK
        {
            get
            {
                return _DBVK;
            }
        }
        public double PM
        {
            get
            {
                return _PM;
            }
        }
        public double NPD
        {
            get
            {
                return _NPD;
            }
        }

        public double NPDnur
        {
            get
            {
                return _NPD;
            }
            set
            {
                _NPD = value;
            }
        }

        public double atl
        {
            get
            {
                return atlyginimas;
            }
            set
            {
                atlyginimas = value;
            }
        }
        public void maziauNei300()
        {
            _NPD = 300;

            _PM = 0;
        }
        public void maziauLygu555_Daugiau300()
        {
            _NPD = 300;

            atlyginimasDaugiauNurNPD();
        }
        public void daugiauNei555()
        {
            _NPD = 300 - (0.15 * (atl - 555));

            atlyginimasDaugiauNurNPD();
        }
        public void daugiauNei2555()
        {
            _NPD = 0;

            atlyginimasDaugiauNurNPD();
        }
        public void nekintantysMokesciai()
        {
            _SSD = atlyginimas * 0.0698;

            _Sodra = (atlyginimas * 1.77) / 100;

            _DBVK = atlyginimas + _Sodra;
        }

        public void bazinisSPsD()
        {
            _SPSD = (atlyginimas * 12.52) / 100;
        }
        public void viensAstuoni()
        {
            _SPSD = (atlyginimas * 14.32) / 100;
        }

        public void trys()
        {
            _SPSD = (atlyginimas * 15.52) / 100;
        }

        public void atlyginimasDaugiauNurNPD()
        {
            _PM = (atlyginimas - NPD) * 0.2;
        }

        public void atlyginimasMaziauArLyguNurNPD()
        {
            _PM = 0;
        }
    }
}
