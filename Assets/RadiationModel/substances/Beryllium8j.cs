using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium8j : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium8j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.03482d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.39399999999999996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Beryllium7()), new(1.0d, new NeutronParticle()) } },
            { 0.27d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.11699999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    