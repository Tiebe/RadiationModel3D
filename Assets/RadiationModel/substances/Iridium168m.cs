using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium168m";
        public override double halfLife { get; } = 0.222d;
        public override double atomicWeight { get; } = 167.98001d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium164()), new(1.0d, new AlphaParticle(7447002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    