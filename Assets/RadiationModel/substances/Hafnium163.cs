using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium163";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 162.94711d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium163()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 1e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium159()), new(1.0d, new AlphaParticle(5162002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    