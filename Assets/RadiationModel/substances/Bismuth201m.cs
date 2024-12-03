using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth201m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth201m";
        public override double halfLife { get; } = 3510.0d;
        public override double atomicWeight { get; } = 200.9779d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.887d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium201()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth201()) } },
            { 0.003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium197()), new(1.0d, new AlphaParticle(6368002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    