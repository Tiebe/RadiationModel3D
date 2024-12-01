using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold173m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold173m";
        public override double halfLife { get; } = 0.0122d;
        public override double atomicWeight { get; } = 172.98645d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.92d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium169()), new(1.0d, new AlphaParticle(8072002.09)) } },
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
    