using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium197m";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 196.97021d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium197()), new(0.305d, new GammaParticle(222450.0, 0.00557)), new(0.914d, new GammaParticle(385800.0, 0.00321)), new(0.21625513168000002d, new GammaParticle(12148.0, 0.10206)), new(0.04858150087425844d, new GammaParticle(70832.0, 0.0175)), new(0.08200793530428502d, new GammaParticle(72874.0, 0.01701)), new(0.027889956685779912d, new GammaParticle(82629.0, 0.015)), new(0.03617327382145654d, new GammaParticle(83631.0, 0.01483)), new(0.008283317135676633d, new GammaParticle(84866.0, 0.01461)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    