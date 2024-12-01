using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium110";
        public override double halfLife { get; } = 18.6d;
        public override double atomicWeight { get; } = 109.92246d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin110()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 6.7e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin106()), new(1.0d, new AlphaParticle(3721002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    