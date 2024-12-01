using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Titanium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium59";
        public override double halfLife { get; } = 0.0285d;
        public override double atomicWeight { get; } = 58.97222d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Vanadium59()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    