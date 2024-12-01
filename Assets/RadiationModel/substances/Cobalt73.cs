using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt73 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt73";
        public override double halfLife { get; } = 0.0407d;
        public override double atomicWeight { get; } = 72.95924d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel73()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.22d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel73()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    