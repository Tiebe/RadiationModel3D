using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold172m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold172m";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 171.99017d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium168()), new(1.0d, new AlphaParticle(8107002.09)) } },
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
    