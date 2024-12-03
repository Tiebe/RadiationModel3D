using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium160m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium160m";
        public override double halfLife { get; } = 30.8d;
        public override double atomicWeight { get; } = 159.93194d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium160()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    