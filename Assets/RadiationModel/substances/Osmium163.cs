using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium163";
        public override double halfLife { get; } = 0.0055d;
        public override double atomicWeight { get; } = 162.98246d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten159()), new(1.0d, new AlphaParticle(7687002.09)) } },
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
    