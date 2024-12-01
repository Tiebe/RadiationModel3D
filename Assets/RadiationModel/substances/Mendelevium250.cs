using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mendelevium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium250";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 250.08417d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.93d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium250()) } },
            { 0.07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Einsteinium246()), new(1.0d, new AlphaParticle(9177002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    