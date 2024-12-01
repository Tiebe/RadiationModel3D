using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium225";
        public override double halfLife { get; } = 0.0036d;
        public override double atomicWeight { get; } = 225.03395d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium221()), new(1.0d, new AlphaParticle(9847002.09)) } },
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
    