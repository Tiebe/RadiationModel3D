using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium106 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium106";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 105.9375d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin102()), new(1.0d, new AlphaParticle(5307002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    