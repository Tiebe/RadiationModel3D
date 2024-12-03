using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium41r : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium41r";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 40.97235d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.59d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Calcium40()), new(1.0d, new ProtonParticle()) } },
            { 0.41d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium41()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    