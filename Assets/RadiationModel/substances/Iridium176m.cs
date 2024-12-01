using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium176m";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 175.96368d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium176()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.031d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium172()), new(1.0d, new AlphaParticle(6337002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    