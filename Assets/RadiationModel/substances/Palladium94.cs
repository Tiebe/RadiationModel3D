using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium94";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 93.92904d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium94()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    