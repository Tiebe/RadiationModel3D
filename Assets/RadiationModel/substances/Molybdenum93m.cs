using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum93m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum93m";
        public override double halfLife { get; } = 24660.0d;
        public override double atomicWeight { get; } = 92.90941d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9987999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum93()), new(0.006790000000000001d, new GammaParticle(114045.0, 0.01087)), new(0.574d, new GammaParticle(263049.0, 0.00471)), new(0.9990000000000001d, new GammaParticle(684693.0, 0.00181)), new(4.99416e-05d, new GammaParticle(827000.0, 0.0015)), new(0.0021974299999999998d, new GammaParticle(947800.0, 0.00131)), new(0.00809d, new GammaParticle(1363016.0, 0.00091)), new(0.991d, new GammaParticle(1477138.0, 0.00084)), new(0.000998832d, new GammaParticle(2161800.0, 0.00057)), new(0.015d, new GammaParticle(2440.0, 0.50813)), new(0.0662d, new GammaParticle(17374.0, 0.07136)), new(0.126d, new GammaParticle(17479.0, 0.07093)), new(0.0331d, new GammaParticle(19681.0, 0.063)), new(0.0382d, new GammaParticle(19794.0, 0.06264)), new(0.0051d, new GammaParticle(19963.0, 0.06211)) } },
            { 0.0012d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium93()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000136d, new GammaParticle(155940.0, 0.00795)), new(0.0005600000000000001d, new GammaParticle(385300.0, 0.00322)), new(0.00061d, new GammaParticle(541290.0, 0.00229)), new(0.0005600000000000001d, new GammaParticle(572796.0, 0.00216)), new(0.0004d, new GammaParticle(689053.0, 0.0018)), new(0.00015d, new GammaParticle(844960.0, 0.00147)), new(0.00117d, new GammaParticle(949810.0, 0.00131)), new(0.00033d, new GammaParticle(1261910.0, 0.00098)), new(0.00031d, new GammaParticle(1417750.0, 0.00087)), new(4.2900000000000006e-05d, new GammaParticle(2299.0, 0.5393)), new(0.00021600000000000002d, new GammaParticle(16521.0, 0.07505)), new(0.000412d, new GammaParticle(16615.0, 0.07462)), new(0.000107d, new GammaParticle(18694.0, 0.06632)), new(0.000123d, new GammaParticle(18795.0, 0.06597)), new(1.6e-05d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    