using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lithium4 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium4";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 4.02718d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Helium3()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    