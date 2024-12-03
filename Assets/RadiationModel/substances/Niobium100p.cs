using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium100p : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium100p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 99.91513d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium100()), new(0.0092d, new GammaParticle(28000.0, 0.04428)), new(0.212d, new GammaParticle(34300.0, 0.03615)), new(0.024d, new GammaParticle(67100.0, 0.01848)), new(0.024d, new GammaParticle(101900.0, 0.01217)), new(0.012d, new GammaParticle(106600.0, 0.01163)), new(0.384d, new GammaParticle(173300.0, 0.00715)), new(0.4d, new GammaParticle(185400.0, 0.00669)), new(0.35200000000000004d, new GammaParticle(358600.0, 0.00346)), new(0.24d, new GammaParticle(392300.0, 0.00316)), new(0.052941535996d, new GammaParticle(2299.0, 0.5393)), new(0.20036803343593682d, new GammaParticle(16521.0, 0.07505)), new(0.38267386064923004d, new GammaParticle(16615.0, 0.07462)), new(0.0990157234042027d, new GammaParticle(18694.0, 0.06632)), new(0.1138680819148331d, new GammaParticle(18795.0, 0.06597)), new(0.014852358510630406d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    