using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium210";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 210.0094d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium206()), new(1.0d, new AlphaParticle(8604002.09)) } },
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
    