using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium222";
        public override double halfLife { get; } = 4.9d;
        public override double atomicWeight { get; } = 222.01784d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium218()), new(1.0d, new AlphaParticle(8160002.09)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium222()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    