using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium227";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 227.03498d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium223()), new(1.0d, new AlphaParticle(8837002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    