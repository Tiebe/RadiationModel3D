using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gallium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium75";
        public override double halfLife { get; } = 126.0d;
        public override double atomicWeight { get; } = 74.9265d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium75()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    