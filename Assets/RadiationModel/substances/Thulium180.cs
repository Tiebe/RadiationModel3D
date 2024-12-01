using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium180";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 179.95902d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium180()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    