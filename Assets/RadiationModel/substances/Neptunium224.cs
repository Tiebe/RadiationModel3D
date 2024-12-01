using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium224";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 224.03439d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium220()), new(1.0d, new AlphaParticle(10351002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    