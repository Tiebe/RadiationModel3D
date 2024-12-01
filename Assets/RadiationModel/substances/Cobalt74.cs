using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt74 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt74";
        public override double halfLife { get; } = 0.0313d;
        public override double atomicWeight { get; } = 73.96399d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel74()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.18d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel74()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    