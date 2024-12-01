using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium242n : RadioactiveSubstance
    {
        public override string name { get; } = "Americium242n";
        public override double halfLife { get; } = 0.0139d;
        public override double atomicWeight { get; } = 242.06191d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 5e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium238()), new(1.0d, new AlphaParticle(8812402.09)) } },
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
    