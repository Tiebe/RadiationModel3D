using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium195m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium195m";
        public override double halfLife { get; } = 3.6d;
        public override double atomicWeight { get; } = 194.97029d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium195()), new(0.0063273d, new GammaParticle(99000.0, 0.01252)), new(0.917d, new GammaParticle(383640.0, 0.00323)), new(0.2900134166745704d, new GammaParticle(12148.0, 0.10206)), new(0.01823382722610312d, new GammaParticle(70832.0, 0.0175)), new(0.030779586809762186d, new GammaParticle(72874.0, 0.01701)), new(0.010467783876588043d, new GammaParticle(82629.0, 0.015)), new(0.013576715687934691d, new GammaParticle(83631.0, 0.01483)), new(0.0031089318113466493d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    