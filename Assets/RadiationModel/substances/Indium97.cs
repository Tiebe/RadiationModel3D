using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium97";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 96.94912d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium97()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.017d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver96()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    