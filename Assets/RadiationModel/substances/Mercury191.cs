using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury191 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury191";
        public override double halfLife { get; } = 2940.0d;
        public override double atomicWeight { get; } = 190.96716d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum191()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    