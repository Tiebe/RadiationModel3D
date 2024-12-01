using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold173 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold173";
        public override double halfLife { get; } = 0.0263d;
        public override double atomicWeight { get; } = 172.98622d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.94d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium169()), new(1.0d, new AlphaParticle(7858002.09)) } },
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
    