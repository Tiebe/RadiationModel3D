using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium91n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium91n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 90.90917d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium91()), new(0.06509999999999999d, new GammaParticle(50100.0, 0.02475)), new(0.33635d, new GammaParticle(194100.0, 0.00639)), new(0.01302d, new GammaParticle(603500.0, 0.00205)), new(0.01085d, new GammaParticle(1082600.0, 0.00115)), new(0.363475d, new GammaParticle(1790600.0, 0.00069)), new(0.626045d, new GammaParticle(1984600.0, 0.00062)), new(0.03196102244791235d, new GammaParticle(2299.0, 0.5393)), new(0.1420903818175442d, new GammaParticle(16521.0, 0.07505)), new(0.27137200499912945d, new GammaParticle(16615.0, 0.07462)), new(0.07021669925677945d, new GammaParticle(18694.0, 0.06632)), new(0.08074920414529636d, new GammaParticle(18795.0, 0.06597)), new(0.010532504888516918d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    