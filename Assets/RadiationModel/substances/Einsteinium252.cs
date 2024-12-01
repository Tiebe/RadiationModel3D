using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Einsteinium252 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium252";
        public override double halfLife { get; } = 40754880.0d;
        public override double atomicWeight { get; } = 252.08297d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.78d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Berkelium248()), new(1.0d, new AlphaParticle(7757002.09)), new(0.005600000000000001d, new GammaParticle(52330.0, 0.02369)), new(0.0028100000000000004d, new GammaParticle(64420.0, 0.01925)), new(0.00125d, new GammaParticle(70650.0, 0.01755)), new(0.00033d, new GammaParticle(80700.0, 0.01536)), new(0.0002d, new GammaParticle(149100.0, 0.00832)), new(0.00075d, new GammaParticle(151300.0, 0.00819)), new(0.00053d, new GammaParticle(193500.0, 0.00641)), new(0.00028000000000000003d, new GammaParticle(228000.0, 0.00544)), new(0.00025d, new GammaParticle(230900.0, 0.00537)), new(0.00024d, new GammaParticle(326000.0, 0.0038)), new(0.00125d, new GammaParticle(377400.0, 0.00329)), new(0.00234d, new GammaParticle(399700.0, 0.0031)), new(0.00226d, new GammaParticle(418500.0, 0.00296)), new(9.36e-05d, new GammaParticle(428300.0, 0.00289)), new(0.00031d, new GammaParticle(452400.0, 0.00274)), new(0.000125d, new GammaParticle(523000.0, 0.00237)), new(0.00055d, new GammaParticle(529100.0, 0.00234)), new(7.8e-05d, new GammaParticle(548000.0, 0.00226)), new(0.00086d, new GammaParticle(590000.0, 0.0021)), new(0.0616827533380968d, new GammaParticle(19075.0, 0.065)), new(0.001826963992167292d, new GammaParticle(107218.0, 0.01156)), new(0.002843966363896781d, new GammaParticle(112150.0, 0.01106)), new(0.0010728650965553374d, new GammaParticle(126449.0, 0.00981)), new(0.001452659340735927d, new GammaParticle(128067.0, 0.00968)), new(0.00037979424418058946d, new GammaParticle(130195.0, 0.00952)) } },
            { 0.22d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium252()), new(0.00021999999999999998d, new GammaParticle(45720.0, 0.02712)), new(0.0158d, new GammaParticle(102330.0, 0.01212)), new(0.00117d, new GammaParticle(106020.0, 0.01169)), new(0.11699999999999999d, new GammaParticle(139030.0, 0.00892)), new(0.00121d, new GammaParticle(165000.0, 0.00751)), new(0.0039000000000000003d, new GammaParticle(694000.0, 0.00179)), new(0.0073d, new GammaParticle(715800.0, 0.00173)), new(0.00064d, new GammaParticle(748600.0, 0.00166)), new(0.0043d, new GammaParticle(759100.0, 0.00163)), new(0.00154d, new GammaParticle(765300.0, 0.00162)), new(0.154d, new GammaParticle(785100.0, 0.00158)), new(0.0125d, new GammaParticle(800000.0, 0.00155)), new(0.0033d, new GammaParticle(804800.0, 0.00154)), new(0.0063d, new GammaParticle(818100.0, 0.00152)), new(0.0029d, new GammaParticle(821800.0, 0.00151)), new(0.00029d, new GammaParticle(854500.0, 0.00145)), new(0.0202d, new GammaParticle(924100.0, 0.00134)), new(0.19271551491558242d, new GammaParticle(19579.0, 0.06333)), new(0.024566709848210987d, new GammaParticle(109867.0, 0.01128)), new(0.03801719258466572d, new GammaParticle(115063.0, 0.01078)), new(0.014492142598763484d, new GammaParticle(129671.0, 0.00956)), new(0.019651345363923288d, new GammaParticle(131332.0, 0.00944)), new(0.005159202765159801d, new GammaParticle(133529.0, 0.00929)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    