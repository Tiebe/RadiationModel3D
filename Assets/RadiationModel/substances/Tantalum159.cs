using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum159 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum159";
        public override double halfLife { get; } = 0.83d;
        public override double atomicWeight { get; } = 158.96303d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.66d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium159()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium155()), new(1.0d, new AlphaParticle(6703002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    