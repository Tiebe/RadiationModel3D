using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Oxygen16p : RadioactiveSubstance
    {
        public override string name { get; } = "Oxygen16p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 16.00884d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.78d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nitrogen15()), new(1.0d, new ProtonParticle()) } },
            { 0.22d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Carbon12()), new(1.0d, new AlphaParticle(6828602.09)) } },
            { 0.0028000000000000004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen16()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    