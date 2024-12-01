using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium187m";
        public override double halfLife { get; } = 15.6d;
        public override double atomicWeight { get; } = 186.97626d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium187()) } },
            { 0.9990000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold187()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0015d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold183()), new(1.0d, new AlphaParticle(6677002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    