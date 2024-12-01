using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium216";
        public override double halfLife { get; } = 0.15d;
        public override double atomicWeight { get; } = 216.01913d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.98d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium212()), new(1.0d, new AlphaParticle(9121002.09)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium216()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    