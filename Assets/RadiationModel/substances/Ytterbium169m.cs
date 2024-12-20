using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Ytterbium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium169m";
        public override double halfLife { get; } = 46.0d;
        public override double atomicWeight { get; } = 168.93521d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium169()), new(3.88e-06d, new GammaParticle(24200.0, 0.05123)), new(0.170646d, new GammaParticle(8502.0, 0.14583)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    