using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon200 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon200";
        public override double halfLife { get; } = 1.03d;
        public override double atomicWeight { get; } = 199.99571d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.86d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium196()), new(1.0d, new AlphaParticle(8066002.09)) } },
            { 0.14d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium200()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    