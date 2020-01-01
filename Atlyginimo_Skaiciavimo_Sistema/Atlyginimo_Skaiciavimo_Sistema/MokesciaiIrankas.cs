using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlyginimo_Skaiciavimo_Sistema
{
    class MokesciaiIrankas
    {
        private double atlyginimas;
        private double _TikrasAtlyginimas;
        private double _Skirtumas;
        private double _NPD;
        private double NPD3;
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
        public double TikrasAtlyginimas
        {
            get
            {
                return _TikrasAtlyginimas;
            }
            set
            {
                _TikrasAtlyginimas = value;
            }
        }

        public double Skirtumas
        {
            get
            {
                return _Skirtumas;
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
        public void maziauNei399_17()
        {
            _NPD = 300;

            _TikrasAtlyginimas = atlyginimas / 1.330578512396694;

            TikrasAtlyginimasMaziauNeiNPD2();
        }
        public void maziauLygu654_15_Daugiau399_17()
        {
            _NPD = 300;

            _Skirtumas = NPD / 3.025012604219184;

            atlyginimas_Skirtumas();

            TikrasAtlyginimas_NPD();
        }

        public void daugiauNei654_15()
        {
            _NPD = (300 - (0.15 * (atl - 555))) * 1.052173226840117;

            _Skirtumas = NPD / 3.02503781316173;

            atlyginimas_Skirtumas();

            TikrasAtlyginimas_NPD();
        }

        public void daugiauNei2554_99()
        {
            _NPD = 0;

            _Skirtumas = NPD / 3.02;

            atlyginimas_Skirtumas();

            TikrasAtlyginimas_NPD();
        }

        public void atlyginimas_Skirtumas()
        {
            _TikrasAtlyginimas = atlyginimas - Skirtumas;
        }
        public void nekintantysMokesciai2()
        {
            _SSD = TikrasAtlyginimas * 0.0698;

            _Sodra = (TikrasAtlyginimas * 1.77) / 100;

            _DBVK = TikrasAtlyginimas + _Sodra;
        }
        public void bazinisSPsD2()
        {
            _SPSD = (TikrasAtlyginimas * 12.52) / 100;
        }

        public void maziauNei390_2479338842975()
        {
            _NPD = 300;

            _TikrasAtlyginimas = (atlyginimas / 1.330578512396694) * 1.022858982614295;

            TikrasAtlyginimasMaziauNeiNPD2();

            viensAstuoni2();
        }

        public void maziauNei637_6528925619835irDaugiauNei390_2479338842975()
        {
            _NPD = 300;

            _Skirtumas = NPD / 3.025012604219184;

            _TikrasAtlyginimas = (atlyginimas - Skirtumas) * 1.030666666666667;

            TikrasAtlyginimas_NPD();

            viensAstuoni2();
        }

        public void maziausNei2478_97520661157irDaugiauNei637_6528925619835()
        {
            _NPD = (300 - (0.15 * (atlyginimas - 555))) * 1.052169338394181;

            _Skirtumas = _NPD / 3.025252104342028;

            _TikrasAtlyginimas = (atlyginimas - Skirtumas) * 1.032319734965719;

            _NPD = (300 - (0.15 * (TikrasAtlyginimas - 555)));

            TikrasAtlyginimas_NPD();

            viensAstuoni2();
        }

        public void maziauNei384_297520661157()
        {
            _NPD = 300;

            _TikrasAtlyginimas = (atlyginimas / 1.330551900837892) * 1.038709230662696;

            TikrasAtlyginimasMaziauNeiNPD2();

            trys2();
        }

        public void daugiauNei2478_97520661157()
        {
            _NPD = 0;

            _TikrasAtlyginimas = atlyginimas * 1.030664395227103;

            TikrasAtlyginimas_NPD();

            viensAstuoni2();
        }

        public void maziauNei626_6528925619835irDaugiauNei384_297520661157()
        {
            _NPD = 300;

            _Skirtumas = NPD / 3.025012604219184;

            _TikrasAtlyginimas = (atlyginimas - Skirtumas) * 1.052172594221582;

            TikrasAtlyginimas_NPD();

            trys2();
        }

        public void maziauNei2428_314049586777irDaugiauNei626_6528925619835()
        {
            NPD3 = (300 - (0.15 * (atlyginimas - 555))) * 1.052169338394181;

            _Skirtumas = NPD3 / 3.025252104342028;

            _TikrasAtlyginimas = (atlyginimas - Skirtumas) * 1.055043186389593;

            _NPD = (300 - (0.15 * (_TikrasAtlyginimas - 555)));

            TikrasAtlyginimas_NPD();

            trys2();
        }

        public void daugiauNei2428_314049586777()
        {
            _NPD = 0;

            _TikrasAtlyginimas = atlyginimas * 1.052170332101312;

            TikrasAtlyginimas_NPD();

            trys2();
        }

        public void daugiauArbaLyguNPDnur()
        {
            _TikrasAtlyginimas = (NPDnur + atlyginimas - NPDnur * 1.330578512396694) * 1.030659666852775;

            viensAstuoni2();

            nekintantysMokesciai2();

            TikrasAtlyginimas_NPD();
        }

        public void maziauNPDnur()
        {
            _TikrasAtlyginimas = (NPDnur + atlyginimas - NPDnur * 1.330578512396694) * 1.030663907021175;

            nekintantysMokesciai2();

            TikrasAtlyginimas_NPD();
        }

        public void TikrasAtlyginimasMaziauNeiNPD()
        {
            _TikrasAtlyginimas = atlyginimas / 1.300822413725259;

            TikrasAtlyginimasMaziauNeiNPD2();

            viensAstuoni2();

            nekintantysMokesciai2();
        }

        public void viensAstuoni2()
        {
            _SPSD = (TikrasAtlyginimas * 14.32) / 100;
        }

        public void maziauArbaLyguNPD()
        {
            _TikrasAtlyginimas = (NPD + atlyginimas - NPD * 1.330578512396694) * 1.052171819438957;

            trys2();

            nekintantysMokesciai2();

            TikrasAtlyginimas_NPD();
        }

        public void TikrasAtlyginimasMaziauNeiNPD2()
        {
            _PM = 0;
        }
        public void trys2()
        {
            _SPSD = (TikrasAtlyginimas * 15.52) / 100;
        }

        public void atlyginimasDaugiauNurNPD()
        {            
            atlyginimasMaziauNurNPD();
        }

        public void atlyginimasMaziauNurNPD()
        {
            TikrasAtlyginimas = NPDnur + atlyginimas - NPDnur * 1.330578512396694;

            TikrasAtlyginimas_NPD();

            nekintantysMokesciai2();

            bazinisSPsD2();
        }

        public void TikrasAtlyginimasMaziauNPD()
        {
            TikrasAtlyginimas = atlyginimas / 1.330572192168985;

            TikrasAtlyginimasMaziauNeiNPD2();

            nekintantysMokesciai2();

            bazinisSPsD2();
        }

        public void TikrasAtlyginimasMaziauNPD2()
        {
            TikrasAtlyginimas = NPDnur + atlyginimas - NPDnur * 1.330578512396694;

            TikrasAtlyginimasMaziauNeiNPD2();

            nekintantysMokesciai2();

            bazinisSPsD2();
        }

        public void AtlyginimasMaziauNeiNPD()
        {
            _TikrasAtlyginimas = (NPDnur + atlyginimas - NPDnur * 1.330578512396694) * 1.052153139736907;

            TikrasAtlyginimas_NPD();

            nekintantysMokesciai2();

            trys2();
        }

        public void _TikrasAtlyginimasMaziauNeiNPD()
        {
            _TikrasAtlyginimas = atlyginimas / 1.280992311984624;

            TikrasAtlyginimasMaziauNeiNPD2();

            trys2();

            nekintantysMokesciai2();
        }

        public void TikrasAtlyginimas_NPD()
        {
            _PM = (TikrasAtlyginimas - NPDnur) * 0.2;
        }
    }
}
