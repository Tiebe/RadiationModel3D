using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium160m";
        public override double halfLife { get; } = 74.5d;
        public override double atomicWeight { get; } = 159.93534d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium160()), new(0.047d, new GammaParticle(42020.0, 0.02951)), new(0.1429646d, new GammaParticle(8215.0, 0.15092)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium160()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    