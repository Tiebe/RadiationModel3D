using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium170m";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 169.93973d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium170()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    