using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium156";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 155.9594d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium152()), new(1.0d, new AlphaParticle(7047002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    