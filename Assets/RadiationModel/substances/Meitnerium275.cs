using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Meitnerium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium275";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 275.14898d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bohrium271()), new(1.0d, new AlphaParticle(11507002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    