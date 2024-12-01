using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium220";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 220.03272d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium216()), new(1.0d, new AlphaParticle(11253002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    