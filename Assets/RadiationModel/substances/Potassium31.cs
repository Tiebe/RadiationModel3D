using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Potassium31 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium31";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 31.03678d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Argon30()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    