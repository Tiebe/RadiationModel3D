using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum175 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum175";
        public override double halfLife { get; } = 2.53d;
        public override double atomicWeight { get; } = 174.9724d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.64d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium171()), new(1.0d, new AlphaParticle(7185002.09)) } },
            { 0.36d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium175()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    