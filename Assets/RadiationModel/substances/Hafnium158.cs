using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium158";
        public override double halfLife { get; } = 2.85d;
        public override double atomicWeight { get; } = 157.9548d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.557d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium158()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.44299999999999995d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium154()), new(1.0d, new AlphaParticle(6427002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    