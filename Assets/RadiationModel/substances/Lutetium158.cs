using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium158";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 157.94932d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9909d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium158()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0091d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium154()), new(1.0d, new AlphaParticle(5812002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    