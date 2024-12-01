using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine108 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine108";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 107.94335d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony104()), new(1.0d, new AlphaParticle(5127002.09)) } },
            { 0.09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Antimony108()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium107()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    