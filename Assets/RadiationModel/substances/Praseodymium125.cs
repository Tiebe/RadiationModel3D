using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium125";
        public override double halfLife { get; } = 3.3d;
        public override double atomicWeight { get; } = 124.93766d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lanthanum125()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
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
    