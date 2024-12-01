using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum158m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158m";
        public override double halfLife { get; } = 0.0367d;
        public override double atomicWeight { get; } = 157.96674d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium154()), new(1.0d, new AlphaParticle(7287002.09)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium158()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    