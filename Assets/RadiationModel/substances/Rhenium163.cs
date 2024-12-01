using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhenium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium163";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 162.97209d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.68d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum163()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.32d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum159()), new(1.0d, new AlphaParticle(7034002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    