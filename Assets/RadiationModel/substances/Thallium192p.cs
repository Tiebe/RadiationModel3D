using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium192p : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium192p";
        public override double halfLife { get; } = 648.0d;
        public override double atomicWeight { get; } = 191.97242d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold192()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    